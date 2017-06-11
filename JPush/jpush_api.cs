﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using cn.jpush.api;
using cn.jpush.api.common;
using cn.jpush.api.push.mode;
using cn.jpush.api.push.notification;
using cn.jpush.api.common.resp;
namespace JPush
{
    class jpush_api
    {
        public static String TITLE = "Test from C# v3 sdk";
        public static String ALERT = "Test from  C# v3 sdk - alert";
        public static String MSG_CONTENT = "Test from C# v3 sdk - msgContent";
        public static String REGISTRATION_ID = "0900e8d85ef";
        public static String SMSMESSAGE = "Test from C# v3 sdk - SMSMESSAGE";
        public static int DELAY_TIME = 1;
        public static String TAG = "tag_api";
        public static String app_key = "2ad3375a7fc1d9fb346df0b2";
        public static String master_secret = "9c478374ebcc89f69ef4ab72";

        public static void Main(string[] args)
        {
            Console.WriteLine("*****开始发送******");
            JPushClient client = new JPushClient(app_key, master_secret);

            PushPayload payload = PushObject_All_All_Alert();
            try
            {
                var result = client.SendPush(payload);
                //由于统计数据并非非是即时的,所以等待一小段时间再执行下面的获取结果方法
                System.Threading.Thread.Sleep(10000);
                //如需查询上次推送结果执行下面的代码
                var apiResult = client.getReceivedApi(result.msg_id.ToString());
                var apiResultv3 = client.getReceivedApi_v3(result.msg_id.ToString());
                //如需查询某个messageid的推送结果执行下面的代码
                var queryResultWithV2 = client.getReceivedApi("1739302794");
                var querResultWithV3 = client.getReceivedApi_v3("1739302794");

            }
            catch (APIRequestException e)
            {
                Console.WriteLine("Error response from JPush server. Should review and fix it. ");
                Console.WriteLine("HTTP Status: " + e.Status);
                Console.WriteLine("Error Code: " + e.ErrorCode);
                Console.WriteLine("Error Message: " + e.ErrorMessage);
            }
            catch (APIConnectionException e)
            {
                Console.WriteLine(e.Message);
            }

            //send   smsmessage
            PushPayload pushsms = PushSendSmsMessage();
            try
            {
                var result = client.SendPush(pushsms);
                //由于统计数据并非非是即时的,所以等待一小段时间再执行下面的获取结果方法
                System.Threading.Thread.Sleep(10000);
                //如需查询上次推送结果执行下面的代码
                var apiResult = client.getReceivedApi(result.msg_id.ToString());
                var apiResultv3 = client.getReceivedApi_v3(result.msg_id.ToString());
            }
            catch (APIRequestException e)
            {
                Console.WriteLine("Error response from JPush server. Should review and fix it. ");
                Console.WriteLine("HTTP Status: " + e.Status);
                Console.WriteLine("Error Code: " + e.ErrorCode);
                Console.WriteLine("Error Message: " + e.ErrorMessage);
            }
            catch (APIConnectionException e)
            {
                Console.WriteLine(e.Message);
            }

            PushPayload payload_alias = PushObject_all_alias_alert();
            try
            {
                var result = client.SendPush(payload_alias);
                //由于统计数据并非非是即时的,所以等待一小段时间再执行下面的获取结果方法
                System.Threading.Thread.Sleep(10000);
                //如需查询上次推送结果执行下面的代码
                var apiResult = client.getReceivedApi(result.msg_id.ToString());
                var apiResultv3 = client.getReceivedApi_v3(result.msg_id.ToString());

            }
            catch (APIRequestException e)
            {
                Console.WriteLine("Error response from JPush server. Should review and fix it. ");
                Console.WriteLine("HTTP Status: " + e.Status);
                Console.WriteLine("Error Code: " + e.ErrorCode);
                Console.WriteLine("Error Message: " + e.ErrorMessage);
            }
            catch (APIConnectionException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("*****结束发送******");


            //Android 平台上的通知，JPush SDK 按照一定的通知栏样式展示。
            PushPayload payload_options = PushObject_android_with_options();
            try
            {
                var result = client.SendPush(payload_options);
                //由于统计数据并非非是即时的,所以等待一小段时间再执行下面的获取结果方法
                System.Threading.Thread.Sleep(10000);
                //如需查询上次推送结果执行下面的代码
                var apiResult = client.getReceivedApi(result.msg_id.ToString());
                var apiResultv3 = client.getReceivedApi_v3(result.msg_id.ToString());

            }
            catch (APIRequestException e)
            {
                Console.WriteLine("Error response from JPush server. Should review and fix it. ");
                Console.WriteLine("HTTP Status: " + e.Status);
                Console.WriteLine("Error Code: " + e.ErrorCode);
                Console.WriteLine("Error Message: " + e.ErrorMessage);
            }
            catch (APIConnectionException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("*****结束发送******");

            PushPayload payload_all_alias = PushObject_all_alias_alert();
            try
            {
                var result = client.SendPush(payload_alias);
                //由于统计数据并非非是即时的,所以等待一小段时间再执行下面的获取结果方法
                System.Threading.Thread.Sleep(10000);
                //如需查询上次推送结果执行下面的代码
                var apiResult = client.getReceivedApi(result.msg_id.ToString());
                var apiResultv3 = client.getReceivedApi_v3(result.msg_id.ToString());

            }
            catch (APIRequestException e)
            {
                Console.WriteLine("Error response from JPush server. Should review and fix it. ");
                Console.WriteLine("HTTP Status: " + e.Status);
                Console.WriteLine("Error Code: " + e.ErrorCode);
                Console.WriteLine("Error Message: " + e.ErrorMessage);
            }
            catch (APIConnectionException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("*****结束发送******");


            PushPayload payload_apns_production_options = PushObject_apns_production_options();
            try
            {
                var result = client.SendPush(payload_apns_production_options);
                //由于统计数据并非非是即时的,所以等待一小段时间再执行下面的获取结果方法
                System.Threading.Thread.Sleep(10000);
            }
            catch (APIRequestException e)
            {
                Console.WriteLine("Error response from JPush server. Should review and fix it. ");
                Console.WriteLine("HTTP Status: " + e.Status);
                Console.WriteLine("Error Code: " + e.ErrorCode);
                Console.WriteLine("Error Message: " + e.ErrorMessage);
            }
            catch (APIConnectionException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("*****结束发送******");


            PushPayload payload_ios_alert_json = PushObject_ios_alert_json();
            try
            {
                var result = client.SendPush(payload_ios_alert_json);
                //由于统计数据并非非是即时的,所以等待一小段时间再执行下面的获取结果方法
                System.Threading.Thread.Sleep(10000);
            }
            catch (APIRequestException e)
            {
                Console.WriteLine("Error response from JPush server. Should review and fix it. ");
                Console.WriteLine("HTTP Status: " + e.Status);
                Console.WriteLine("Error Code: " + e.ErrorCode);
                Console.WriteLine("Error Message: " + e.ErrorMessage);
            }
            catch (APIConnectionException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("*****结束发送******");
        }


        public static PushPayload PushObject_All_All_Alert()
        {
            PushPayload pushPayload = new PushPayload();
            pushPayload.platform = Platform.all();
            pushPayload.audience = Audience.all();
            pushPayload.notification = new Notification().setAlert(ALERT);
            return pushPayload;
        }
        public static PushPayload PushObject_all_alia_alert()
        {

            PushPayload pushPayload_alias = new PushPayload();
            pushPayload_alias.platform = Platform.android();
            pushPayload_alias.audience = Audience.s_alias("alias1");
            pushPayload_alias.notification = new Notification().setAlert(ALERT);
            return pushPayload_alias;
        }

        public static PushPayload PushObject_all_alias_alert()
        {

            PushPayload pushPayload_alias = new PushPayload();
            pushPayload_alias.platform = Platform.android();
            string[] alias = new string[] { "alias1", "alias2", "alias3" };
            Console.WriteLine(alias);
            pushPayload_alias.audience = Audience.s_alias(alias);
            pushPayload_alias.notification = new Notification().setAlert(ALERT);
            return pushPayload_alias;
        }

        public static PushPayload PushObject_Android_Tag_AlertWithTitle()
        {
            PushPayload pushPayload = new PushPayload();

            pushPayload.platform = Platform.android();
            pushPayload.audience = Audience.s_tag("tag1");
            pushPayload.notification = Notification.android(ALERT, TITLE);
            return pushPayload;
        }
        public static PushPayload PushObject_android_and_ios()
        {
            PushPayload pushPayload = new PushPayload();
            pushPayload.platform = Platform.android_ios();
            var audience = Audience.s_tag("tag1");
            pushPayload.audience = audience;
            var notification = new Notification().setAlert("alert content");
            notification.AndroidNotification = new AndroidNotification().setTitle("Android Title");
            notification.IosNotification = new IosNotification();
            notification.IosNotification.incrBadge(1);
            notification.IosNotification.AddExtra("extra_key", "extra_value");
            pushPayload.notification = notification.Check();
            return pushPayload;
        }


        public static PushPayload PushObject_android_with_options()
        {
            PushPayload pushPayload = new PushPayload();
            pushPayload.platform = Platform.android_ios();
            var audience = Audience.all();
            pushPayload.audience = audience;
            var notification = new Notification().setAlert("alert content");
            AndroidNotification androidnotification = new AndroidNotification();
            androidnotification.setAlert("Push Object android with options");
            androidnotification.setBuilderID(3);
            androidnotification.setStyle(1);
            androidnotification.setBig_text("big text content");
            androidnotification.setInbox("JSONObject");
            //androidnotification.setBig_pic_patht("picture url");
            androidnotification.setPriority(0);
            androidnotification.setCategory("category str");
            notification.AndroidNotification = androidnotification;
            notification.IosNotification = new IosNotification();
            notification.IosNotification.incrBadge(1);
            notification.IosNotification.AddExtra("extra_key", "extra_value");
            pushPayload.notification = notification.Check();
            return pushPayload;
        }

        public static PushPayload PushObject_ios_tagAnd_alertWithExtrasAndMessage()
        {
            PushPayload pushPayload = new PushPayload();
            pushPayload.platform = Platform.android_ios();
            pushPayload.audience = Audience.s_tag_and("tag1", "tag_all");
            var notification = new Notification();
            notification.IosNotification = new IosNotification().setAlert(ALERT).setBadge(5).setSound("happy").AddExtra("from", "JPush");
            pushPayload.notification = notification;
            pushPayload.message = Message.content(MSG_CONTENT);
            return pushPayload;
        }


        public static PushPayload PushObject_ios_alert_json()
        {
            PushPayload pushPayload = new PushPayload();
            pushPayload.platform = Platform.all();
            pushPayload.audience = Audience.all();
            var notification = new Notification();
            Hashtable alert = new Hashtable();
            alert["title"] = "JPush Title";
            alert["subtitle"] = "JPush Subtitle";
            alert["body"] = "JPush Body";
            notification.IosNotification = new IosNotification().setAlert(alert).setBadge(5).setSound("happy").AddExtra("from", "JPush");
            pushPayload.notification = notification;
            pushPayload.message = Message.content(MSG_CONTENT);
            return pushPayload;
        }

        public static PushPayload PushObject_ios_audienceMore_messageWithExtras()
        {

            var pushPayload = new PushPayload();
            pushPayload.platform = Platform.android_ios();
            pushPayload.audience = Audience.s_tag("tag1", "tag2");
            pushPayload.message = Message.content(MSG_CONTENT).AddExtras("from", "JPush");
            return pushPayload;

        }


        public static PushPayload PushObject_apns_production_options()
        {

            var pushPayload = new PushPayload();
            pushPayload.platform = Platform.android_ios();
            pushPayload.audience = Audience.s_tag("tag1", "tag2");
            pushPayload.message = Message.content(MSG_CONTENT).AddExtras("from", "JPush");
            pushPayload.options.apns_production = false;
            return pushPayload;

        }

        public static PushPayload PushSendSmsMessage()
        {
            var pushPayload = new PushPayload();
            pushPayload.platform = Platform.all();
            pushPayload.audience = Audience.all();
            pushPayload.notification = new Notification().setAlert(ALERT);
            SmsMessage sms_message = new SmsMessage();
            sms_message.setContent(SMSMESSAGE);
            sms_message.setDelayTime(DELAY_TIME);
            pushPayload.sms_message = sms_message;
            return pushPayload;
        }
    }
}
