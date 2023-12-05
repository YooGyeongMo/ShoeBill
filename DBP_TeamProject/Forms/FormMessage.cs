using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_TeamProject.Forms
{
    public partial class FormMessage : Form
    {

        DBManager dbManager = DBManager.GetInstance();
        Query query = Query.GetInstance();
        LoginedUser loginedUser = LoginedUser.getInstance();
        private System.Windows.Forms.Timer messageCheckTimer;
        private bool isNotificationShown = false;
        string userId = LoginedUser.getInstance().UserId;
        private bool errorMessageShown = false;

        public FormMessage()
        {
            InitializeComponent();

            PopulateComboBox();
            ShowReceivedMessagesForUser();//자동으로 로그인한 유저 정보 받게 설정////////////////////////////////////////////////////////////////

        }


        public void MessageCheckTimer_Tick(object sender, EventArgs e)
        {
            ShowReceivedMessagesForUser(); // 새로운 메시지 확인

            if (HasNewMessages() && !isNotificationShown)
            {
                isNotificationShown = true;
            }
        }

        private bool HasNewMessages()
        {
            try
            {
                DBManager dbManager = DBManager.GetInstance();
                string query = $"SELECT COUNT(*) FROM message WHERE recipient_id = {userId} AND state = 1";
                DataTable result = dbManager.FindDataTable(query);

                if (result != null && result.Rows.Count > 0)
                {
                    int messageCount = Convert.ToInt32(result.Rows[0][0]);
                    return messageCount > 0;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"새로운 메시지 확인 중 오류 발생: {ex.Message}");
                return false;
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBManager dbManager = DBManager.GetInstance();
            if (listBox1.SelectedIndex != -1)
            {
                string selectedItem =
                    listBox1.SelectedItem.ToString();
                string messageContent = GetMessageContent(selectedItem); //
                richTextBox1.Text = messageContent;

                string[] parts = selectedItem.Split(new string[] { "제목: ", ", 발신자: ", ", 상태: " }, StringSplitOptions.RemoveEmptyEntries);

                string title = parts[0];
                string senderName = parts[1];
                string status = parts[2];

                if (status == "안 읽음")
                {
                    dbManager.InitDBManager();
                    string senderIdQuery = $"SELECT 사원ID FROM 사원 WHERE 이름 = '{senderName}'";
                    try
                    {
                        int senderId = Convert.ToInt32(dbManager.FindDataTable(senderIdQuery).Rows[0]["사원ID"]);
                        string updateQuery = $"UPDATE message SET state = 0 WHERE title = '{title}' AND sender_id = {senderId}";
                        dbManager.ExecuteNonQueury(updateQuery);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"상태 변경 중 오류 발생: {ex.Message}");
                    }
                    finally
                    {
                        dbManager.CloseConnection();
                    }
                }
                ShowReceivedMessagesForUser();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private string GetMessageContent(string selectedItem)
        {
            DBManager dbManager = DBManager.GetInstance();

            string[] parts = selectedItem.Split(new string[] { "제목: ", ", 발신자: ", ", 상태: " }, StringSplitOptions.RemoveEmptyEntries);
            string title = parts[0];
            string senderName = parts[1];
            string status = parts[2];

            string senderIdQuery = $"SELECT 사원ID FROM 사원 WHERE 이름 = '{senderName}'";

            try
            {
                int senderId = Convert.ToInt32(dbManager.FindDataTable(senderIdQuery).Rows[0]["사원ID"]);
                string query = $"SELECT content FROM message WHERE title = '{title}' AND sender_id = {senderId}";

                DataTable dataTable = dbManager.FindDataTable(query);
                if (dataTable.Rows.Count > 0)
                {
                    string messageContent = dataTable.Rows[0]["content"].ToString();
                    return messageContent;
                }
                else
                {
                    return "해당하는 내용을 찾을 수 없습니다.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"메시지 내용을 가져오는 중 오류 발생: {ex.Message}");
                return "오류 발생";
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        public void PopulateComboBox()
        {
            DBManager dbManager = DBManager.GetInstance();
            string query = "SELECT 사원ID, 부서이름, 이름, 직급 FROM 사원";

            try
            {
                DataTable dataTable = dbManager.FindDataTable(query);
                comboBox1.Items.Clear();

                foreach (DataRow row in dataTable.Rows)
                {
                    string item = $"{row["부서이름"]} {row["이름"]} {row["직급"]} {row["사원ID"]}";
                    comboBox1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 로드 중 오류 발생: {ex.Message}");
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int recipientId = ExtractRecipientId();
            string title = textBox1.Text;
            string content = richTextBox1.Text;

            if (recipientId != -1 && !string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(content))
            {
                SendMessage(recipientId, title, content);
            }
            else
            {
                MessageBox.Show("모든 필드를 입력하세요.");
            }
        }

        private void SendMessage(int recipientId, string title, string content)
        {
            DBManager dbManager = DBManager.GetInstance();
            dbManager.InitDBManager();
            try
            {
                string query = "INSERT INTO message (sender_id, recipient_id, title, content, sent_time, state) " +
                "VALUES (@senderId, @recipientId, @title, @content, NOW(), @state)";

                MySqlCommand cmd = new MySqlCommand(query, dbManager.Connection);
                cmd.Parameters.AddWithValue("@senderId", userId); //자동으로 받아지게////////////////////////////////////////////////////////////////////////////////////////////////
                cmd.Parameters.AddWithValue("@recipientId", recipientId);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@content", content);
                cmd.Parameters.AddWithValue("@state", 1);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("메시지가 전송되었습니다.");
                }
                else
                {
                    MessageBox.Show("메시지 전송에 실패했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"메시지 전송 중 오류 발생: {ex.Message}");
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }
        private void ShowReceivedMessagesForUser()
        {
            DBManager dbManager = DBManager.GetInstance();
            try
            {
                string query = $"SELECT m.id, m.title, e.이름 as sender_name, m.state, m.checkstate " +
                               $"FROM message m " +
                               $"JOIN 사원 e ON m.sender_id = e.사원ID " +
                               $"WHERE recipient_id = {userId}";
                DataTable dataTable = dbManager.FindDataTable(query);

                listBox1.Items.Clear();

                foreach (DataRow row in dataTable.Rows)
                {
                    string messageTitle = row["title"].ToString();
                    string senderName = row["sender_name"].ToString();

                    string status = "알 수 없음";
                    int checkstate = Convert.ToInt32(row["checkstate"]);
                    if (row["state"] != DBNull.Value)
                    {
                        int state = Convert.ToInt32(row["state"]);
                        status = state == 1 ? "안 읽음" : "읽음";
                    }

                    listBox1.Items.Add($"제목: {messageTitle}, 발신자: {senderName}, 상태: {status}");
                    MoveUnreadMessagesToTop();

                    if (checkstate == 1)
                    {
                        ShowNotification($"새로운 메시지: {messageTitle}", row);
                    }
                }
                dbManager.CloseConnection();
            }
            catch (Exception ex)
            {
                if (!errorMessageShown)
                {
                    errorMessageShown = true;
                    MessageBox.Show($"메시지 가져오기 중 오류 발생: {ex.Message}");
                    errorMessageShown = false; // 에러 메시지 창이 닫힌 후에 다시 false로 설정해줍니다.
                }
            }
            finally
            {
                dbManager.CloseConnection();
            }

        }
        private void MoveUnreadMessagesToTop()
        {
            int unreadIndex = -1;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string item = listBox1.Items[i].ToString();
                if (item.Contains("안 읽음"))
                {
                    unreadIndex = i;
                    break;
                }
            }

            if (unreadIndex != -1)
            {
                string unreadMessage = listBox1.Items[unreadIndex].ToString();
                listBox1.Items.RemoveAt(unreadIndex);
                listBox1.Items.Insert(0, unreadMessage);
            }
        }
        private int ExtractRecipientId()
        {
            int recipientId = -1;

            if (comboBox1.SelectedItem != null)
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                string[] selectedParts = selectedItem.Split(' ');

                if (int.TryParse(selectedParts.Last(), out recipientId))
                {
                    return recipientId;
                }
            }

            return recipientId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchText = textBox2.Text;
            string query = $"SELECT m.title, e.이름 as sender_name, m.state " +
                           $"FROM message m " +
                           $"JOIN 사원 e ON m.sender_id = e.사원ID " +
                           $"WHERE (m.title LIKE '%{searchText}%' OR m.content LIKE '%{searchText}%' OR e.이름 LIKE '%{searchText}%') AND recipient_id = {userId}";

            DataTable dataTable = dbManager.FindDataTable(query);
            listBox1.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                string messageTitle = row["title"].ToString();
                string senderName = row["sender_name"].ToString();

                string status = "알 수 없음";
                if (row["state"] != DBNull.Value)
                {
                    int state = Convert.ToInt32(row["state"]);
                    status = state == 1 ? "안 읽음" : "읽음";
                }

                listBox1.Items.Add($"제목: {messageTitle}, 발신자: {senderName}, 상태: {status}");
            }
            messageCheckTimer.Stop();
            Task.Delay(3000).ContinueWith((task) => messageCheckTimer.Start(), TaskScheduler.FromCurrentSynchronizationContext());
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {

        }
        private async void ShowNotification(string message, DataRow messageRow)
        {
            int messageId = Convert.ToInt32(messageRow["id"]);
            int status = Convert.ToInt32(messageRow["checkstate"]);

            isNotificationShown = true; // 팝업이 떠있음을 설정

            UpdateMessageStatusInDB(messageId, 0); // 상태를 확인된 상태(0)로 업데이트

            DialogResult result = MessageBox.Show(message, "새로운 메시지 도착", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowReceivedMessagesForUser();
        }

        private void UpdateMessageStatusInDB(int messageId, int newStatus)
        {
            DBManager dbManager = DBManager.GetInstance();
            dbManager.InitDBManager();
            try
            {
                string updateQuery = $"UPDATE message SET checkstate = {newStatus} WHERE id = {messageId}";
                int rowsAffected = dbManager.ExecuteNonQueury(updateQuery);

                if (rowsAffected > 0)
                {
                    // 업데이트 성공
                }
                else
                {
                    MessageBox.Show("메시지 상태 업데이트에 실패했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"메시지 상태 업데이트 중 오류 발생: {ex.Message}");
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void FormMessage_Shown(object sender, EventArgs e)
        {
            messageCheckTimer = new System.Windows.Forms.Timer();
            messageCheckTimer.Interval = 3000; // 3초마다 확인
            messageCheckTimer.Tick += new EventHandler(MessageCheckTimer_Tick);
            messageCheckTimer.Start();
        }
        public void StopTimer()
        {

            if (messageCheckTimer != null)
            {
                messageCheckTimer.Stop();
                messageCheckTimer.Dispose();
                messageCheckTimer = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StopTimer();
        }
    }
}

