using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;

/// <summary>
/// ToServiceXML2 的摘要说明
/// </summary>
public class ToServiceXML
{   
    //获取发送短信消息体
    public static string getSendSmsXMLstr(string txt, List<string> mobiles)
    {
        System.Text.StringBuilder ss = new System.Text.StringBuilder();
        ss.Append("<?xml version=\"1.0\" encoding=\"gb2312\"?>");
        ss.Append("<SmsInfo>");
        ss.Append("<Login>");
        ss.Append("<UserID>38050509</UserID>");//用户名
        ss.Append("<Password>000000</Password>");//密码
        ss.Append("</Login>");
        ss.Append("<SendTaskList>");
        //每增加一个被叫号码 就需要增加一个SendTask 节点
        foreach (string mobile in mobiles)
        {
            ss.Append("<SendTask>");
            ss.Append("<ClientTaskID>1</ClientTaskID>");//int型，查询清单接口中短信系统会返回此字段，短信系统不效验唯一性
            ss.Append("<SmsNumber>" + mobile + "</SmsNumber>");//短信号码.
            ss.Append("</SendTask>");
        }
        ss.Append("</SendTaskList>");
        ss.Append("<SmsOptions>");
        ss.Append("<ExpectTime></ExpectTime>");//期望发送时间 时间格式如：2011-05-31 10:07:57
        ss.Append("<Priority>1</Priority>");//Priority 优先级.1-低,2-高 （非必填项，系统默认 1）
        ss.Append("<Content>" + txt + "</Content>");//短信内容
        ss.Append("</SmsOptions>");
        ss.Append("</SmsInfo>");

        return ss.ToString();
    }

    //获取短信发送结果
    public static string getQueryResultForSmsTaskXMLstr()
    {
        System.Text.StringBuilder qrfs = new System.Text.StringBuilder();
        qrfs.Append("<?xml version=\"1.0\" encoding=\"gb2312\"?>");
        qrfs.Append("<SmsInfo>");
        qrfs.Append("<QueryResultForSmsTask>");
        qrfs.Append("<Login>");
        qrfs.Append("<UserID>00000001</UserID>");//用户名
        qrfs.Append("<Password>1</Password>");//密码
        qrfs.Append("</Login>");
        qrfs.Append("</QueryResultForSmsTask>");
        qrfs.Append("</SmsInfo>");
        return qrfs.ToString();
    }

    //获取短信接收结果
    public static string getQueryRecvSmsTaskXMLstr()
    {
        System.Text.StringBuilder qrrs = new System.Text.StringBuilder();
        qrrs.Append("<?xml version=\"1.0\" encoding=\"gb2312\"?>");
        qrrs.Append("<SmsInfo>");
        qrrs.Append("<QueryRecvSmsTask>");
        qrrs.Append("<Login>");
        qrrs.Append("<UserID>00000001</UserID>");//用户名
        qrrs.Append("<Password></Password>");//密码
        qrrs.Append("</Login>");
        //qrrs.Append("<StartTimeFilter></StartTimeFilter>");
        //qrrs.Append("<EndTimeFilter></EndTimeFilter>");
        qrrs.Append("</QueryRecvSmsTask>");
        qrrs.Append("</SmsInfo>");
        return qrrs.ToString();
    }

    //查询用户信息 消息体
    public static string getGetUserInfoXMLstr()
    {
        System.Text.StringBuilder gusb = new System.Text.StringBuilder();
        gusb.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
        gusb.Append("<UserInfo> ");
        gusb.Append("<GetUserInfo>");
        gusb.Append("<Login>" );
        gusb.Append("<UserID>00000001</UserID>");//传真系统分配的用户名
        gusb.Append("<Password>1</Password>");//传真系统分配的密码
        gusb.Append("</Login>" );
        gusb.Append("</GetUserInfo>");
        gusb.Append("</UserInfo>");
        return gusb.ToString();
    }
    //修改密码消息体
    public static string getChangePasswordXMLstr()
    {
        System.Text.StringBuilder cpsb = new System.Text.StringBuilder();
        cpsb.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
        cpsb.Append("<UserInfo> ");
        cpsb.Append("<ChangePassword>");
        cpsb.Append("<Login>" );
        cpsb.Append("<UserID>00000001</UserID>");//传真系统分配的用户名
        cpsb.Append("<Password></Password>");//传真系统分配的密码
        cpsb.Append("</Login>");
        cpsb.Append("</ChangePassword>");
        cpsb.Append("</UserInfo>");
        return cpsb.ToString();
    }
  
}
