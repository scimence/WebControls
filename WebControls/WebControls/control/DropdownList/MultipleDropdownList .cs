using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebControls.control.DropdownList
{
    /// <summary>
    /// 多选下拉控件
    /// </summary>
    [ToolboxData("<{0}:MultipleDropdownList runat=server></{0}:MultipleDropdownList>")]
    public class MultipleDropdownList : CompositeControl
    {
        #region Fields
        private CheckBoxList _checkBoxes;
        private TextBox _textBox;
        private static ListItem _selectAllItem = new ListItem("全选", "___selectAll___");
        #endregion

        #region 数据绑定属性
        public Object DataSource
        {
            get { return ViewState["_dataSource"]; }
            set { ViewState["_dataSource"] = value; }
        }

        public string DataTextField
        {
            get { return ViewState["DataTextField"] == null ? "" : ViewState["DataTextField"].ToString(); }
            set { ViewState["DataTextField"] = value; }
        }

        public string DataValueField
        {
            get { return ViewState["DataValueField"] == null ? "" : ViewState["DataValueField"].ToString(); }
            set { ViewState["DataValueField"] = value; }
        }

        public string DataTextFormatString
        {
            get { return ViewState["DataTextFormatString"] == null ? "" : ViewState["DataTextFormatString"].ToString(); }
            set { ViewState["DataTextFormatString"] = value; }
        }
        #endregion

        #region Properties
        public IEnumerable<String> SelectedValues
        {
            get
            {
                foreach (ListItem item in SelectedItems)
                {
                    yield return item.Value;
                }
            }
        }

        public IEnumerable<ListItem> SelectedItems
        {
            get
            {
                foreach (ListItem item in _checkBoxes.Items)
                {
                    if (IsSelectedAllItem(item)) continue;

                    if (item.Selected) yield return item;
                }
            }
        }

        /// <summary>
        /// 用逗号隔开后的选中的值
        /// </summary>
        public String SelectedValuesJoined
        {
            get { return String.Join(",", SelectedValues.ToArray()); }
        }
        #endregion

        public override void DataBind()
        {
            EnsureChildControls();
            _checkBoxes.DataSource = DataSource;
            _checkBoxes.DataTextField = DataTextField;
            _checkBoxes.DataValueField = DataValueField;
            _checkBoxes.DataTextFormatString = DataTextFormatString;

            base.DataBind();//由于这个Bind,会递归其子控件的Bind,所以把Insert全选放到下边，以防在Bind之前清空了数据

            _checkBoxes.Items.Insert(0, _selectAllItem);
        }

        protected override void CreateChildControls()
        {
            base.CreateChildControls();

            _textBox = new TextBox();
            if (Width.Value > 0) _textBox.Width = Width;
            Controls.Add(_textBox);

            //下拉框的容器
            HtmlGenericControl div = new HtmlGenericControl("div");
            div.Style.Add(HtmlTextWriterStyle.BackgroundColor, "white");
            div.Style.Add(HtmlTextWriterStyle.Display, "none");
            div.Style.Add(HtmlTextWriterStyle.Position, "absolute");

            //使用CheckBoxList作为多选
            _checkBoxes = new CheckBoxList();
            _checkBoxes.RepeatDirection = RepeatDirection.Vertical;
            _checkBoxes.RepeatLayout = RepeatLayout.Flow;
            div.Controls.Add(_checkBoxes);

            Controls.Add(div);
        }

        protected override void AddAttributesToRender(HtmlTextWriter writer)
        {
            base.AddAttributesToRender(writer);
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "__MultipleDropdownList__");
            writer.AddStyleAttribute(HtmlTextWriterStyle.Display, "block");
            writer.AddStyleAttribute("float", "left");
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            //包含js
            var jsUrl = Page.ClientScript.GetWebResourceUrl(this.GetType(),
                                                            "cslc.Athena.WebExtendControl.MultipleDropdownList.js");

            this.Page.ClientScript.RegisterClientScriptInclude("MultipleDropdownList_js", jsUrl);

            //包含css
            var cssUrl = Page.ClientScript.GetWebResourceUrl(this.GetType(),
                                                            "cslc.Athena.WebExtendControl.MultipleDropdownList.css");
            string csslink = "<link href='" + cssUrl + "' rel='stylesheet' type='text/css' />";
            LiteralControl include = new LiteralControl(csslink);
            this.Page.Header.Controls.Add(include);

        }

        //某选项是否为“全选”项
        private bool IsSelectedAllItem(ListItem item)
        {
            return item.Value == _selectAllItem.Value && item.Text == _selectAllItem.Text;
        }
    }

}