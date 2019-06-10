using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WebControls.control.formDemo1
{
    [DefaultProperty ("CardholderNameText")]
    [ToolboxData("<{0}:FormDemo1 runat='server' PaymentMethodText='支付方式'></{0}:FormDemo1>")]
    public class FormDemo1 : Control
    {
        private string paymentMethod = "支付方式";

        [Browsable (true )]//在属性窗口中是否可见
        [Category ("Appearance")]//属性的分类，如，行为，外观，大家可以在属性窗口看见这样的分类
        [DefaultValue ("支付方式")]
        [Description ("支付方式")]//这些是显示在属性窗口底下的
        public virtual string PaymentMethodText
        {
            get
            {
                return paymentMethod;
            }
            set
            {
                paymentMethod = value;
            }
        }

        protected override void Render(HtmlTextWriter writer)
         {
             writer.Write ("<table style='width:287px;height:128px;border-width:0'>");
             writer.Write ("<tr>");
             writer.Write("<td>" + PaymentMethodText + "</td>");
             writer.Write ("<td>");
             writer.Write ("<select name='paymentMethod' id='paymentMethod' style='width:100%'>");
             writer.Write ("<option value='0'>Master</option>");
             writer.Write ("<option value='1'>Visa</option>");
             writer.Write ("</select>");
             writer.Write ("</td>");
             writer.Write("</tr>");
 
             writer.Write("<tr>");
             writer.Write("<td>信用卡号</td>");
             writer.Write("<td><input type='text' name='CreditCardNo' id='CreditCardNo'/></td>");
             writer.Write("</tr>");
 
             writer.Write("<tr>");
             writer.Write("<td>持卡人</td>");
             writer.Write("<td><input type='text' name='CardholderName' id='CardholderName' /></td>");
             writer.Write("</tr>");
 
             writer.Write("<tr>");
             writer.Write("<td>过期时间</td>");
             writer.Write("<td>");
             writer.Write("<select name='Month' id='Month'>");
             for (int month = 1; month < 13; month++)
             {
                 writer.Write("<option value=" + month.ToString() + ">" + month.ToString() + "</option>");
             }
 
             writer.Write("</select>");
 
             writer.Write("&nbsp");
 
             writer.Write("<select name='Year' id='Year'>");
             for (int year = 2008; year< 2014; year ++)
             {
                 writer.Write("<option value=" + year.ToString() + ">" + year.ToString() + "</option>");
             }
             writer.Write("</select>");
             writer.Write("</td></tr>");
 
             writer.Write("<tr>");
             writer.Write("<td align='center' colspan='2'>");
             writer.Write("<input type='submit' value='提交'/>");
             writer.Write("</td></tr>");
 
         }
    }

}