using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using TrasenFrame.Classes;
using TrasenClasses.GeneralControls;
using TrasenClasses.GeneralClasses;
using YpClass;
namespace ts_yp_xtwh
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Frmsccj : System.Windows.Forms.Form
	{
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private myDataGrid.myDataGrid myDataGrid1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
		private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtdm;
		private System.Windows.Forms.Button butsave;
		private System.Windows.Forms.Button butdel;
		private System.Windows.Forms.Button butquit;
		private MenuTag _menuTag;
		private string _chineseName;
		private Form _mdiParent;
		private System.Windows.Forms.Button butprint;

		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Frmsccj(MenuTag menuTag,string chineseName,Form mdiParent)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			_menuTag=menuTag;
			_chineseName=chineseName;
			_mdiParent=mdiParent;
			this.Text=_chineseName;
            this.Text = this.Text + " [" + InstanceForm._menuTag.Jgbm + "]";
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.myDataGrid1 = new myDataGrid.myDataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butprint = new System.Windows.Forms.Button();
            this.butquit = new System.Windows.Forms.Button();
            this.butdel = new System.Windows.Forms.Button();
            this.butsave = new System.Windows.Forms.Button();
            this.txtdm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 454);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(768, 31);
            this.statusBar1.TabIndex = 0;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 300;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Width = 1001;
            // 
            // myDataGrid1
            // 
            this.myDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.myDataGrid1.CaptionVisible = false;
            this.myDataGrid1.DataMember = "";
            this.myDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.myDataGrid1.Location = new System.Drawing.Point(3, 21);
            this.myDataGrid1.Name = "myDataGrid1";
            this.myDataGrid1.Size = new System.Drawing.Size(762, 347);
            this.myDataGrid1.TabIndex = 0;
            this.myDataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyle1});
            this.myDataGrid1.myKeyDown += new myDataGrid.myDelegate(this.myDataGrid1_myKeyDown);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.AllowSorting = false;
            this.dataGridTableStyle1.DataGrid = this.myDataGrid1;
            this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.dataGridTextBoxColumn1,
            this.dataGridTextBoxColumn2,
            this.dataGridTextBoxColumn3,
            this.dataGridTextBoxColumn4,
            this.dataGridTextBoxColumn5,
            this.dataGridTextBoxColumn6,
            this.dataGridTextBoxColumn7,
            this.dataGridBoolColumn1,
            this.dataGridTextBoxColumn8});
            this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "序号";
            this.dataGridTextBoxColumn1.Width = 40;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "名称";
            this.dataGridTextBoxColumn2.Width = 150;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "拼音码";
            this.dataGridTextBoxColumn3.Width = 70;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "五笔码";
            this.dataGridTextBoxColumn4.Width = 70;
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "联系电话";
            this.dataGridTextBoxColumn5.Width = 70;
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "联系人";
            this.dataGridTextBoxColumn6.Width = 60;
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.HeaderText = "地址";
            this.dataGridTextBoxColumn7.Width = 75;
            // 
            // dataGridBoolColumn1
            // 
            this.dataGridBoolColumn1.AllowNull = false;
            this.dataGridBoolColumn1.FalseValue = ((short)(0));
            this.dataGridBoolColumn1.HeaderText = "GMP达标";
            this.dataGridBoolColumn1.NullValue = ((short)(0));
            this.dataGridBoolColumn1.TrueValue = ((short)(1));
            this.dataGridBoolColumn1.Width = 50;
            // 
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            this.dataGridTextBoxColumn8.HeaderText = "ID";
            this.dataGridTextBoxColumn8.NullText = "";
            this.dataGridTextBoxColumn8.Width = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butprint);
            this.groupBox1.Controls.Add(this.butquit);
            this.groupBox1.Controls.Add(this.butdel);
            this.groupBox1.Controls.Add(this.butsave);
            this.groupBox1.Controls.Add(this.txtdm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // butprint
            // 
            this.butprint.Location = new System.Drawing.Point(725, 21);
            this.butprint.Name = "butprint";
            this.butprint.Size = new System.Drawing.Size(128, 41);
            this.butprint.TabIndex = 8;
            this.butprint.Text = "打印(&P)";
            this.butprint.Click += new System.EventHandler(this.butprint_Click);
            // 
            // butquit
            // 
            this.butquit.Location = new System.Drawing.Point(864, 21);
            this.butquit.Name = "butquit";
            this.butquit.Size = new System.Drawing.Size(128, 41);
            this.butquit.TabIndex = 4;
            this.butquit.Text = "退出(&Q)";
            this.butquit.Click += new System.EventHandler(this.butquit_Click);
            // 
            // butdel
            // 
            this.butdel.Location = new System.Drawing.Point(587, 21);
            this.butdel.Name = "butdel";
            this.butdel.Size = new System.Drawing.Size(128, 41);
            this.butdel.TabIndex = 3;
            this.butdel.Text = "删除(&D)";
            this.butdel.Click += new System.EventHandler(this.butdel_Click);
            // 
            // butsave
            // 
            this.butsave.Location = new System.Drawing.Point(448, 21);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(128, 41);
            this.butsave.TabIndex = 2;
            this.butsave.Text = "保存(&S)";
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // txtdm
            // 
            this.txtdm.Location = new System.Drawing.Point(91, 31);
            this.txtdm.Name = "txtdm";
            this.txtdm.Size = new System.Drawing.Size(256, 25);
            this.txtdm.TabIndex = 1;
            this.txtdm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdm_KeyUp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "查找";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.myDataGrid1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 371);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "厂家信息";
            // 
            // Frmsccj
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 18);
            this.ClientSize = new System.Drawing.Size(768, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusBar1);
            this.Name = "Frmsccj";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmsccj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]


		private void Frmsccj_Load(object sender, System.EventArgs e)
		{
			try
			{
				//初始化
				DataTable myTb=new DataTable();
			
				for(int i=0;i<=this.myDataGrid1.TableStyles[0].GridColumnStyles.Count-1;i++) 
				{	
					if(this.myDataGrid1.TableStyles[0].GridColumnStyles[i].GetType().ToString()=="System.Windows.Forms.DataGridBoolColumn")
						myTb.Columns.Add(this.myDataGrid1.TableStyles[0].GridColumnStyles[i].HeaderText,Type.GetType("System.Int16"));	
					else
						myTb.Columns.Add(this.myDataGrid1.TableStyles[0].GridColumnStyles[i].HeaderText,Type.GetType("System.String"));	
									   
					this.myDataGrid1.TableStyles[0].GridColumnStyles[i].MappingName=this.myDataGrid1.TableStyles[0].GridColumnStyles[i].HeaderText;
					this.myDataGrid1.TableStyles[0].GridColumnStyles[i].NullText="";
				}
			
				this.myDataGrid1.DataSource=myTb;
				this.myDataGrid1.TableStyles[0].MappingName ="Tb";
				this.AddData("");
			}
			catch(System.Exception err)
			{
				MessageBox.Show("发生错误"+err.Message);
			}
		}

		private void AddData(string ss)
		{
			DataTable myTb=new DataTable();
			string ssql="";

			if (ss.Trim()=="")
			{
				 ssql="select 0 序号,sccj 名称,pym 拼音码,wbm 五笔码,lxdh 联系电话,lxr 联系人,lxdz 地址,cast(gmp as smallint) GMP达标,id from yp_sccj";
			}
			else
			{
				ssql="select 0 序号,sccj 名称,pym 拼音码,wbm 五笔码,lxdh 联系电话,lxr 联系人,lxdz 地址,cast(gmp as smallint) GMP达标,id from yp_sccj where pym like '"+txtdm.Text.Trim()+"%' or wbm like '"+txtdm.Text.Trim()+"%' or sccj like '%"+txtdm.Text.Trim()+"%' ";
			}
			myTb=InstanceForm.BDatabase.GetDataTable(ssql);
			FunBase.AddRowtNo(myTb);
			myTb.TableName="Tb";
			this.myDataGrid1.DataSource=myTb;
			this.myDataGrid1.TableStyles[0].MappingName ="Tb";
			DataRow row=myTb.NewRow();
			row["序号"]=myTb.Rows.Count+1;
			row["GMP达标"]=(short)(0);
			myTb.Rows.Add(row);
            myTb.AcceptChanges();
		}

		private bool myDataGrid1_myKeyDown(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
		{
			try
			{

				DataTable tb=(DataTable)this.myDataGrid1.DataSource ;
				int nrow=this.myDataGrid1.CurrentCell.RowNumber;
				int ncol=this.myDataGrid1.CurrentCell.ColumnNumber;
				int nkey=Convert.ToInt32(keyData);
				string columnName=this.myDataGrid1.TableStyles[0].GridColumnStyles[ncol].HeaderText.Trim();
				if (nrow>tb.Rows.Count-1) return true;
				if (columnName.Trim()=="名称" && nkey==13)
				{
					string coltext="";
					DataGridTextBoxColumn txtCol=(DataGridTextBoxColumn)this.myDataGrid1.TableStyles[0].GridColumnStyles[ncol];
					coltext=txtCol.TextBox.Text;
					if (coltext.Trim()=="") return true;

					if (nrow>=tb.Rows.Count-1)
					{
						DataRow row=tb.NewRow();
						row["序号"]=nrow+2;
						row["GMP达标"]=(short)(0);
						tb.Rows.Add(row);
					}

					tb.Rows[nrow]["名称"]=coltext;
					tb.Rows[nrow]["拼音码"]=PubStaticFun.GetPYWBM(coltext,0);
					tb.Rows[nrow]["五笔码"]=PubStaticFun.GetPYWBM(coltext,1);
				}

				if (nkey==13 && columnName!="GMP达标")
				  	this.myDataGrid1.CurrentCell=new DataGridCell(nrow,ncol+1);
				if (nkey==13 && columnName=="GMP达标")
					this.myDataGrid1.CurrentCell=new DataGridCell(nrow+1,1);

			}
			catch(System.Exception err)
			{
				MessageBox.Show("错误"+err.Message );
			}
			return false;
		}

		private void txtdm_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				this.AddData(txtdm.Text.Trim());
			}
			catch(System.Exception err)
			{
				MessageBox.Show("发生错误"+err.Message);
			}

		}

		private void butdel_Click(object sender, System.EventArgs e)
		{
            Guid log_djid = Guid.Empty;
            ts_HospData_Share.ts_update_log ts = new ts_HospData_Share.ts_update_log();

			try
			{
				DataTable tb=(DataTable)this.myDataGrid1.DataSource ;
				int nrow=this.myDataGrid1.CurrentCell.RowNumber;
				if (nrow>tb.Rows.Count-1) return;
				if(MessageBox.Show("您确定要删除"+tb.Rows[nrow]["名称"].ToString()+"这个厂家吗 ？","询问窗",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)!=DialogResult.Yes)
				{
					return;
				}
				string ssql="select * from yp_ypcjd where sccj="+Convert.ToInt32(Convertor.IsNull(tb.Rows[nrow]["id"],"0"))+"";
				DataTable myTb=InstanceForm.BDatabase.GetDataTable(ssql);
				if (myTb.Rows.Count!=0) {MessageBox.Show("这个厂家在药典中已经使用了，不能删除它");return;}

				long ID=Convert.ToInt32(Convertor.IsNull(tb.Rows[nrow]["id"],"0"));

                InstanceForm.BDatabase.BeginTransaction();
                ssql = "delete from yp_sccj where id=" + ID + "";
                InstanceForm.BDatabase.DoCommand(ssql);

                //三院数据处理_____保存日志 
                if (ID > 0)
                {
                    string bz = "删除厂家 【" + tb.Rows[nrow]["名称"].ToString() + "】 ";

                    ts.Save_log(ts_HospData_Share.czlx.yp_药品基础数据单表修改, bz, "yp_sccj", "id", ID.ToString(), InstanceForm._menuTag.Jgbm, 0, "", out log_djid, InstanceForm.BDatabase);
                }
                InstanceForm.BDatabase.CommitTransaction();

                DataRow row = tb.Rows[nrow];
                tb.Rows.Remove(row);
			}
			catch(System.Exception err)
			{
                InstanceForm.BDatabase.RollbackTransaction();
                MessageBox.Show("发生错误" + err.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
			}


            try
            {
                //三院数据处理
                string errtext = "";
                ts_HospData_Share.ts_update_type ty = new ts_HospData_Share.ts_update_type((int)ts_HospData_Share.czlx.yp_药品基础数据单表修改, InstanceForm.BDatabase);
                if (ty.Bzx == 1)
                    ts.Pexec_log(log_djid, InstanceForm.BDatabase, out errtext);

                MessageBox.Show("删除成功" + errtext);

            }
            catch (System.Exception err)
            {
                MessageBox.Show("发生错误" + err.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

		}

		private void butquit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void butsave_Click(object sender, System.EventArgs e)
		{
            ts_HospData_Share.ts_update_log ts = new ts_HospData_Share.ts_update_log();
            Guid log_djid = Guid.Empty;
            DataTable tb = (DataTable)this.myDataGrid1.DataSource;
            string[] ss = new string[tb.Rows.Count];

			try
			{
				this.butsave.Enabled=false;
				InstanceForm.BDatabase.BeginTransaction();

				string ssql="";
				string sccj="";
				string pym="";string wbm="";string lxdh="";string lxr="";
				string lxdz="";int gmp=0;
				
				for(int i=0;i<=tb.Rows.Count-1;i++)
				{
                    if ( tb.Rows[i].RowState == DataRowState.Unchanged )
                        continue;

						int ID=Convert.ToInt32(Convertor.IsNull(tb.Rows[i]["id"],"0"));
						sccj=tb.Rows[i]["名称"].ToString();
						pym=tb.Rows[i]["拼音码"].ToString();
						wbm=tb.Rows[i]["五笔码"].ToString();
						lxdh=tb.Rows[i]["联系电话"].ToString();
						lxr=tb.Rows[i]["联系人"].ToString();
						lxdz=tb.Rows[i]["地址"].ToString();
						gmp=Convert.ToInt16(tb.Rows[i]["gmp达标"]);

					if (sccj.Trim()!="")
					{
						if (ID==0)
						{
							ssql="insert into yp_sccj(sccj,pym,wbm,lxdh,lxr,lxdz,gmp) values('"+sccj+"','"+pym+"','"+wbm+"','"+lxdh+"','"+lxr+"','"+lxdz+"',"+gmp+") ";
						}
						else
						{
							ssql="update yp_sccj set sccj='"+sccj+"',pym='"+pym+"',wbm='"+wbm+"',lxdh='"+lxdh+"',lxr='"+lxr+"',lxdz='"+lxdz+"',gmp="+gmp+" where id="+ID+" ";
						}


                        //三院数据处理
                        if (ID == 0)
                        {
                            InstanceForm.BDatabase.DoCommand(ssql);
                            long newid = Convert.ToInt64(InstanceForm.BDatabase.GetDataTable("select @@IDENTITY").Rows[0][0]);
                            ts.Save_log(ts_HospData_Share.czlx.yp_药品基础数据单表修改, InstanceForm.BCurrentUser.Name + "添加药品生产厂家 【" + sccj + " 】", "yp_sccj", "id", newid.ToString(), InstanceForm._menuTag.Jgbm, 0, "", out log_djid, InstanceForm.BDatabase);
                            ss[i] = log_djid.ToString();
                        }
                        else
                        {
                            string _ssql = "select * from yp_sccj where id=" + ID + " and sccj='" + sccj + "' and pym='" + pym + "'";
                            DataTable tb_x = InstanceForm.BDatabase.GetDataTable(_ssql);
                            if (tb_x.Rows.Count == 0)
                            {
                                ts.Save_log(ts_HospData_Share.czlx.yp_药品基础数据单表修改, InstanceForm.BCurrentUser.Name + "修改药品生产厂家 【" + sccj + " 】", "yp_sccj", "id", ID.ToString(), InstanceForm._menuTag.Jgbm, 0, "", out log_djid, InstanceForm.BDatabase);
                                ss[i] = log_djid.ToString();
                            }
                            InstanceForm.BDatabase.DoCommand(ssql);

                            ssql = "update yp_ypcjd set s_sccj='"+sccj+"' where sccj="+ID+"";
                            InstanceForm.BDatabase.DoCommand(ssql);
                        }

					}
				}

				InstanceForm.BDatabase.CommitTransaction();
			}
			catch(System.Exception err)
			{
				this.butsave.Enabled=true;
				InstanceForm.BDatabase.RollbackTransaction();
				MessageBox.Show("发生错误"+err.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
			}

            try
            {
                //三院数据处理
                string msg = "";
                for (int i = 0; i <= ss.Length - 1; i++)
                {
                    if (Convertor.IsNull(ss[i], "") == "") continue;
                    string errtext = "";
                    ts_HospData_Share.ts_update_log tss = new ts_HospData_Share.ts_update_log();
                    ts_HospData_Share.ts_update_type ty = new ts_HospData_Share.ts_update_type((int)ts_HospData_Share.czlx.yp_药品基础数据单表修改, InstanceForm.BDatabase);
                    if (ty.Bzx == 1)
                    {
                        tss.Pexec_log(new Guid(ss[i]), InstanceForm.BDatabase, out errtext);
                        msg = msg + errtext;
                    }
                }

                MessageBox.Show("保存成功" + msg);
                this.butsave.Enabled = true;
                this.AddData("");
            }
            catch (System.Exception err)
            {
                MessageBox.Show("发生错误" + err.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


		}

		private void butprint_Click(object sender, System.EventArgs e)
		{
			try
			{
				#region 简单打印

				this.butprint.Enabled=false;

				Excel.Application myExcel = new Excel.Application( ) ;

				myExcel.Application.Workbooks.Add (true ) ;
			
				//查询条件
				string swhere="";

				//写入行头
				DataTable tb=(DataTable)this.myDataGrid1.DataSource;
				int SumRowCount=tb.Rows.Count;
				int SumColCount=0;

				for(int j=0;j<this.myDataGrid1.TableStyles[0].GridColumnStyles.Count;j++)
				{
					if (this.myDataGrid1.TableStyles[0].GridColumnStyles[j].Width>0)
					{
						SumColCount=SumColCount+1;
						myExcel.Cells[5,SumColCount]=this.myDataGrid1.TableStyles[0].GridColumnStyles[j].HeaderText.Trim() ;
					}
				
				}
				myExcel.get_Range(myExcel.Cells[5,1],myExcel.Cells[5,SumColCount]).Font.Bold = true;
				myExcel.get_Range(myExcel.Cells[5,1],myExcel.Cells[5,SumColCount]).Font.Size = 10;


				//逐行写入数据，
				
				for(int i=0;i<tb.Rows.Count;i++)
				{
					int ncol=0;
					for(int j=0;j<tb.Columns.Count;j++)
					{
						if (this.myDataGrid1.TableStyles[0].GridColumnStyles[j].Width>0)
						{
							ncol=ncol+1;
							myExcel.Cells[6+i,ncol]="'"+tb.Rows[i][j].ToString().Trim();
							
						}
					}
				}

				//设置报表表格为最适应宽度
				myExcel.get_Range(myExcel.Cells[6,1],myExcel.Cells[5+SumRowCount,SumColCount]).Select();
				myExcel.get_Range(myExcel.Cells[6,1],myExcel.Cells[5+SumRowCount,SumColCount]).Columns.AutoFit();
				
				//加边框
				myExcel.get_Range(myExcel.Cells[5,1],myExcel.Cells[5+SumRowCount,SumColCount]).Borders.LineStyle = 1;

				//报表名称
				myExcel.Cells[1,1]="药品生产厂家表";
				myExcel.get_Range(myExcel.Cells[1,1],myExcel.Cells[1,SumColCount]).Font.Bold = true;
				myExcel.get_Range(myExcel.Cells[1,1],myExcel.Cells[1,SumColCount]).Font.Size = 16;
				//报表名称跨行居中
				myExcel.get_Range(myExcel.Cells[1,1],myExcel.Cells[1,SumColCount]).Select();
				myExcel.get_Range(myExcel.Cells[1,1],myExcel.Cells[1,SumColCount]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenterAcrossSelection;

				//报表条件
				myExcel.Cells[3,1]=swhere.Trim();
				myExcel.get_Range(myExcel.Cells[3,1],myExcel.Cells[3,SumColCount]).Font.Size = 10;
				myExcel.get_Range(myExcel.Cells[3,1],myExcel.Cells[3,SumColCount]).Select();
				myExcel.get_Range(myExcel.Cells[3,1],myExcel.Cells[5,SumColCount]).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

				//最后一行为黄色
				//myExcel.get_Range(myExcel.Cells[5+SumRowCount,1],myExcel.Cells[5+SumRowCount,SumColCount]).Interior.ColorIndex = 19;
			

				//让Excel文件可见
				myExcel.Visible=true;
				this.butprint.Enabled=true;

				#endregion 
			}
			catch(System.Exception err)
			{
				this.butprint.Enabled=true;
				MessageBox.Show(err.Message);
			}
		}


	}
}
