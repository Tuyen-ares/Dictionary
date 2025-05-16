using System;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using Dictionary.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Dictionary
{
    public partial class frmDictionary : Form
    {

        private static readonly HttpClient client = new HttpClient();

        List<string> listword = new List<string>();

        Dictionary<string, string> languages = new Dictionary<string, string>()
        {
            { " Vietnamese ","vi" },
            { " English ","en" }
        };

        public void loadLanguage_t1()
        {
            t2_cbobxFrom.DataSource = languages.Keys.ToList();
            t2_cbobxFrom.SelectedIndex = 1;

            t2_cbobxTo.DataSource = languages.Keys.ToList();
            t2_cbobxTo.SelectedIndex = 0;
        }

        public void control(bool isEnable = false)
        {
            lblPhonetics.Visible = isEnable;
            picbxAudio.Visible = isEnable;
        }

        public frmDictionary()
        {
            InitializeComponent();
        }

        public string translateToEnglish()
        {
            return "https://api.dictionaryapi.dev/api/v2/entries/en/" + t1_txtKey.Text.Trim();
        }

        public string translateTo(string source, string target, string key)
        {
            return string.Format("https://translate.projectsegfau.lt/api/translate" +
                "?engine=google&from={0}&to={1}&text={2}", source, target, key);
        }

        async void translateToT2(string url)
        {
            try
            {
                var response = await CallApiAsync(url);
                Dictionary<string, object> result = JsonSerializer.Deserialize<Dictionary<string, object>>(response);
                object mean /*= t2_rtxtKey.Text.Trim()*/;
                result.TryGetValue("translated-text", out mean);
                rtxtResult.Text = mean.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        async void translateToT1_Vi(string url)
        {
            try
            {
                var response = await CallApiAsync(url);
                Dictionary<string, object> result = JsonSerializer.Deserialize<Dictionary<string, object>>(response);
                object mean = t1_txtKey.Text.Trim();
                result.TryGetValue("translated-text", out mean);
                t1_rtxtOutput.Text = mean.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
        async void translateToT1_En(string url)
        {
            rtxtsynonym.Text = "";
            rtxtantonym.Text = "";
            List<string> poslist = new List<string>();
            try
            {
                var response = await CallApiAsync(url);
                List<DictionaryApiEntries> entries = JsonSerializer.Deserialize<List<DictionaryApiEntries>>(response);
                bool isCompleted = false;
                bool isTypeExist = false;
                bool isPhoneticExist = false;
                bool isAudioExist = false;
                int start = 0;
                while (!isCompleted)
                {
                    for (int i = 0; i < entries[start].phonetics.Count; i++)
                    {
                        string text = entries[start].phonetics[i].text;
                        string audio = entries[start].phonetics[i].audio;
                        if (!(string.IsNullOrWhiteSpace(audio) || string.IsNullOrWhiteSpace(text)))
                        {
                            lblPhonetics.Text = text;
                            mdAudio.URL = audio;
                            isPhoneticExist = true;
                            isAudioExist = true;
                            break;
                        }
                    }

                    for (int i = 0; i < entries[start].meanings.Count; i++)
                    {


                        string partOfSpeech = entries[start].meanings[i].partOfSpeech;
                        if (!string.IsNullOrWhiteSpace(partOfSpeech))
                        {
                            string pos = partOfSpeech[0].ToString().ToUpper() + partOfSpeech.Substring(1).ToLower();
                            poslist.Add(pos);
                            comboBoxpartofspeech.Items.Add(pos);
                            isTypeExist = true;
                            continue;

                        }

                    }

                    isCompleted = isPhoneticExist && isTypeExist && isAudioExist;
                    start++;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            if (comboBoxpartofspeech.Items.Count > 0)
            {
                comboBoxpartofspeech.SelectedIndex = 0;
            }
        }


        async Task<string> CallApiAsync(string url)
        {
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception($"Error fetching data: {response.StatusCode}");
            }
        }

        private void frmDictionary_Load(object sender, EventArgs e)
        {
            loadLanguage_t1();
            control();
        }

        private void t2_lblSwap_Click(object sender, EventArgs e)
        {
            int temp = t2_cbobxFrom.SelectedIndex;
            t2_cbobxFrom.SelectedIndex = t2_cbobxTo.SelectedIndex;
            t2_cbobxTo.SelectedIndex = temp;
        }

        private void t1_txtKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string urlTranslateToVI = translateTo("en", "vi", t1_txtKey.Text.Trim());
                translateToT1_Vi(urlTranslateToVI);
                string urlTranslateToEn = translateToEnglish();
                translateToT1_En(urlTranslateToEn);
                control(true);
            }

        }

        private void picbxAudio_Click(object sender, EventArgs e)
        {
            mdAudio.Ctlcontrols.play();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string key = t2_rtxtKey.Text.Trim();
            if (string.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu để dịch !");
                return;
            }

            languages.TryGetValue(t2_cbobxFrom.SelectedItem.ToString(), out string source);
            languages.TryGetValue(t2_cbobxTo.SelectedItem.ToString(), out string target);
            string urlTranslate = translateTo(source, target, key);
            translateToT2(urlTranslate);
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        void MediaTarget()
        {
            languages.TryGetValue(t2_cbobxTo.SelectedItem.ToString(), out string target);
            mediatranslate.URL = string.Format("https://translate.projectsegfau.lt/api/tts?engine=google&lang={0}&text={1}", target, rtxtResult.Text);
        }

        void MediaSource()
        {
            languages.TryGetValue(t2_cbobxFrom.SelectedItem.ToString(), out string source);
            mediatranslate.URL = string.Format("https://translate.projectsegfau.lt/api/tts?engine=google&lang={0}&text={1}", source, t2_rtxtKey.Text);

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MediaSource();
            mediaorigin.Ctlcontrols.play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MediaTarget();
            mediatranslate.Ctlcontrols.play();
        }

        private void rtxtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void t1_rtxtOutput_TextChanged(object sender, EventArgs e)
        {
            rtxtlistword.ForeColor = Color.FromArgb(255, 0, 0);
            string resultext = t1_txtKey.Text.Trim() + " - " + t1_rtxtOutput.Text + "\n";
            rtxtlistword.AppendText(resultext);
        }


        async void TakeSynonym(string url)
        {
            try
            {
                var response = await CallApiAsync(url);
                List<DictionaryApiEntries> entries = JsonSerializer.Deserialize<List<DictionaryApiEntries>>(response);
                int index = 0;
                int i = comboBoxpartofspeech.SelectedIndex;

                for (int j = 0; j < entries[index].meanings[i].synonyms.Count; j++)
                {
                    try
                    {
                        rtxtsynonym.AppendText(entries[index].meanings[i].synonyms[j].ToString() + "\n");

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);

                    }
                }
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (rtxtsynonym.Text.Equals(""))
            {
                MessageBox.Show("Hệ thống chưa thể cập nhật những từ này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        async void TakeAntonym(string url)
        {
            try
            {
                var response = await CallApiAsync(url);
                List<DictionaryApiEntries> entries = JsonSerializer.Deserialize<List<DictionaryApiEntries>>(response);
                int index = 0;
                int i = comboBoxpartofspeech.SelectedIndex;

                for (int j = 0; j < entries[index].meanings[i].antonyms.Count; j++)
                {
                    try
                    {
                        rtxtantonym.AppendText(entries[index].meanings[i].antonyms[j].ToString() + "\n");

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);

                    }
                }
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rtxtantonym.Text.Equals(""))
            {
                MessageBox.Show("Hệ thống chưa thể cập nhật những từ này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        async void TakeDefinition(string url)
        {
            try
            {
                var response = await CallApiAsync(url);
                List<DictionaryApiEntries> entries = JsonSerializer.Deserialize<List<DictionaryApiEntries>>(response);
                int index = 0;
                string defini = "";
                string exm = "";
                object mean;
                string dash = new string('-', 29);
                for (int i = 0; i < entries[index].meanings.Count; i++)
                {
                    for (int j = 0; j < entries[index].meanings[i].definitions.Count; j++)
                    {
                        try
                        {
                            defini = entries[index].meanings[i].definitions[j].definition;


                            string url_en_to_vi = translateTo("en", "vi", defini);
                            var response1 = await CallApiAsync(url_en_to_vi);
                            Dictionary<string, object> result = JsonSerializer.Deserialize<Dictionary<string, object>>(response1);
                            result.TryGetValue("translated-text", out mean);


                            if (!string.IsNullOrEmpty(entries[index].meanings[i].definitions[j].example))
                            {
                                exm = entries[index].meanings[i].definitions[j].example;
                            }
                            richTextBoxdef.AppendText("Định nghĩa: " + defini + "\n");
                            richTextBoxdef.AppendText("Tạm dịch: " + mean.ToString() + "\n");
                            richTextBoxdef.AppendText("Ví dụ: " + exm + "\n");
                            richTextBoxdef.AppendText(dash + "\n");
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message);
                        }

                    }
                }
            }

            catch (Exception err)
            {
                MessageBox.Show("Không có dữ liệu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            rtxtsynonym.Text = "";
            string url = translateToEnglish();
            TakeSynonym(url);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            rtxtantonym.Text = "";
            string url = translateToEnglish();
            TakeAntonym(url);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            richTextBoxdef.Text = "";
            string url = translateToEnglish();
            TakeDefinition(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtxtlistword.Text = "";
        }
    }
}
