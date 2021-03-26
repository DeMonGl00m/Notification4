
using UnityEngine;

using Unity.Notifications.Android;
public class NotificationManager : MonoBehaviour
{

    string []text;
    void Start()
    {
        var channel = new AndroidNotificationChannel()

        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.High,
            Description = "Generic notifications",
            LockScreenVisibility = LockScreenVisibility.Public,
            EnableLights = true,
            EnableVibration=true,
            VibrationPattern= new long[] { 0,1000 }

        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);


         text = new string [14]
        { "������� ����������� - ������������� �������", 
          "������ ��������� ��� ���� �� ������� �������",
          "�� ������ �����, �� � ����� ��������",
          "������ ���������,��� ������ ���������, �� ������", 
          "�� ����, ���� ����",
          "����������������, �������, ������",
          "���� ������ ������, � � �������� �����",
          "����������� ������ �� ����� � ���� - ��� �� ��� ����",
          "���� ������ ������, � � �������� �����",
          "�� ������, �� ������, � ������ ���������?",
          "������� �������� ���, ��-��",
          "� � ���� ��������",
          "������� ������ �� ��������, � �� ��������",
          "����� ������ ���-�� ������, ��� ��� ���� ���������������� �����"
        };
    }




    public void Notification()
    {
        var notification = new AndroidNotification();
        notification.Title = "���� �����������!!!";
        notification.Text = text[Random.Range(0,text.Length)];
        notification.FireTime = System.DateTime.Now.AddSeconds(InputField.VremyZarydki);
        notification.LargeIcon = "bigicon";

        AndroidNotificationCenter.SendNotification(notification, "channel_id");

    }
}
