using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControls.control
{
    public partial class SoftIteam : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // --------------------------------------------
        // 添加自定义属性ImageUrl、Tittle、Note、Size、Note、LinkUrl

        string imageUrl = "";
        [Description("要显示的图像URL"), Category("自定义属性")]
        public string ImageUrl                  // 控件的自定义属性值
        {
            get
            {
                return imageUrl;
            }
            set
            {
                imageUrl = value;
                Icon.ImageUrl = value;
            }
        }

        string tittle = "标题";
        [Description("标题信息"), Category("自定义属性")]
        public string Tittle                  // 控件的自定义属性值
        {
            get
            {
                return tittle;
            }
            set
            {
                tittle = value;
                LabelTittle.Text = value;
            }
        }

        string content = "说明信息";
        [Description("说明信息"), Category("自定义属性")]
        public string Note                  // 控件的自定义属性值
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                LabelContent.Text = value;
                LabelContent.ToolTip = value;
            }
        }

        string size = "100 KB";
        [Description("文件大小信息"), Category("自定义属性")]
        public string Size                  // 控件的自定义属性值
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                LabelSize.Text = value;
            }
        }

        string linkUrl = "";
        [Description("链接Url"), Category("自定义属性")]
        public string LinkUrl                  // 控件的自定义属性值
        {
            get
            {
                return linkUrl;
            }
            set
            {
                linkUrl = value;
            }
        }

        // --------------------------------------------
        // 添加自定义事件 OnClick(object sender, EventArgs e) -> 命名为Click

        protected void Button_Click(object sender, EventArgs e) // 从Button的点击事件，触发自定义控件的点击逻辑
        {
            if (Click != null) Click(this, new EventArgs(), LinkUrl);
        }

        public delegate void Click_Handle(object sender, EventArgs e, string url);  // 自定义事件的参数类型
        [Description("点击当前控件的详情按钮时执行。"), Category("自定义事件")]
        public event Click_Handle Click;    // 定义当前控件的点击事件名称，在属性中为 On此处名称=“Button_Click”

        //[Description("点击当前控件的详情按钮时执行。"), Category("自定义事件")]
        //public event EventHandler Click;
    }
}