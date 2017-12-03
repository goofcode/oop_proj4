using System.Windows.Forms;

namespace oop_proj4
{
    public partial class NewMemberForm : Telerik.WinControls.UI.RadForm
    {
        public const int NEWMEMBER = 1;
        public const int EDITMEMBER = 2;

        public Member returnMember { get; set; }
        public DialogResult result { get; set; }
        public int type { get; set; }

        public NewMemberForm()
        {
            InitializeComponent();

            this.btnApply.Click += (s, e) =>
            {
                this.result = DialogResult.OK;

                if (this.type == NEWMEMBER)
                {
                    this.returnMember = new Member();
                    this.returnMember.RegisterationDate = System.DateTime.Now;
                }

                this.returnMember.Id = int.Parse(txtId.Text);
                this.returnMember.Name = txtName.Text;
                this.returnMember.Tel = txtTel.Text;
                this.returnMember.Gender = int.Parse(ddlGender.SelectedItem.Tag.ToString());
                this.returnMember.BirthDate = dtpBirth.Value;
                this.returnMember.RegisterationState = int.Parse(ddlState.SelectedItem.Tag.ToString());
                this.returnMember.EndDate = dtpEnd.Value;
                this.returnMember.Point = int.Parse(txtPoint.Text);
                this.returnMember.Memo = txtMemo.Text;

                this.Close();
            };

            this.btnCancel.Click += (s, e) =>
            {
                this.result = DialogResult.Cancel;
                this.Close();
            };

            this.ddlGender.SelectedIndex = 0;
            this.ddlState.SelectedIndex = 0;
            this.txtId.Text = DBManager.Instance().getAutoIncrementIDWithMember().ToString();
        }

        public void ShowDialog(int type)
        {
            this.type = type;

            this.ShowDialog();
        }

        public void ShowDialog(int type, Member member)
        {
            this.type = type;

            this.returnMember = member;

            if (this.type == EDITMEMBER)
            {
                this.txtId.Text = this.returnMember.Id.ToString();
                this.txtName.Text = this.returnMember.Name;
                this.txtTel.Text = this.returnMember.Tel;
                for (int i = 0; i < this.ddlGender.Items.Count; i++)
                {
                    if (int.Parse(this.ddlGender.Items[i].Tag.ToString()) == this.returnMember.Gender)
                    {
                        this.ddlGender.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < this.ddlState.Items.Count; i++)
                {
                    if (int.Parse(this.ddlState.Items[i].Tag.ToString()) == this.returnMember.RegisterationState)
                    {
                        this.ddlState.SelectedIndex = i;
                    }
                }
                this.dtpBirth.Value = this.returnMember.BirthDate;
                this.dtpEnd.Value = this.returnMember.EndDate;
                this.txtPoint.Text = this.returnMember.Point.ToString();
                this.txtMemo.Text = this.returnMember.Memo;

                this.btnApply.Text = "적용";
            }

            this.ShowDialog();
        }
    }
}
