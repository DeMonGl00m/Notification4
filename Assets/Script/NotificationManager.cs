
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
        { "Сильный программист - потенциальный грузчик", 
          "Железо поднимать это тебе не клавиши жмакать",
          "Не только умный, но и гроза гопникам",
          "Хорошо поработал,еще хорошо поработай, но руками", 
          "Ум есть, сила надо",
          "Программирование, шахматы, штанга",
          "Одна голова хорошо, а с бицепсом лучше",
          "Оперативная память не лезет в слот - это не про тебя",
          "Одна голова хорошо, а с бицепсом лучше",
          "Мы писали, мы писали, а бицуху подкачали?",
          "Ботаник говорили они, ну-ну",
          "Я у мамы богатырь",
          "Сильный умного не разумеет, а ты полиглот",
          "Пусть теперь кто-то скажит, что его язык программирование лучше"
        };
    }




    public void Notification()
    {
        var notification = new AndroidNotification();
        notification.Title = "Надо подкачаться!!!";
        notification.Text = text[Random.Range(0,text.Length)];
        notification.FireTime = System.DateTime.Now.AddSeconds(InputField.VremyZarydki);
        notification.LargeIcon = "bigicon";

        AndroidNotificationCenter.SendNotification(notification, "channel_id");

    }
}
