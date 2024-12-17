
namespace PKG_6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            tbAngleOx = new System.Windows.Forms.TrackBar();
            tbAngleOy = new System.Windows.Forms.TrackBar();
            tbAngleOz = new System.Windows.Forms.TrackBar();
            tbGlobalCoordsOz = new System.Windows.Forms.TrackBar();
            tbGlobalCoordsOy = new System.Windows.Forms.TrackBar();
            tbGlobalCoordsOx = new System.Windows.Forms.TrackBar();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            numUDTranslateOz = new System.Windows.Forms.NumericUpDown();
            numUDTranslateOy = new System.Windows.Forms.NumericUpDown();
            numUDTranslateOx = new System.Windows.Forms.NumericUpDown();
            bTranslate = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            label11 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            rbProfile = new System.Windows.Forms.RadioButton();
            rbHorizontal = new System.Windows.Forms.RadioButton();
            rbFrontal = new System.Windows.Forms.RadioButton();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            numUDScale = new System.Windows.Forms.NumericUpDown();
            label16 = new System.Windows.Forms.Label();
            bScale = new System.Windows.Forms.Button();
            tb00 = new System.Windows.Forms.TextBox();
            tb10 = new System.Windows.Forms.TextBox();
            tb20 = new System.Windows.Forms.TextBox();
            tb30 = new System.Windows.Forms.TextBox();
            tb01 = new System.Windows.Forms.TextBox();
            tb11 = new System.Windows.Forms.TextBox();
            tb21 = new System.Windows.Forms.TextBox();
            tb31 = new System.Windows.Forms.TextBox();
            tb02 = new System.Windows.Forms.TextBox();
            tb12 = new System.Windows.Forms.TextBox();
            tb22 = new System.Windows.Forms.TextBox();
            tb32 = new System.Windows.Forms.TextBox();
            tb03 = new System.Windows.Forms.TextBox();
            tb13 = new System.Windows.Forms.TextBox();
            tb23 = new System.Windows.Forms.TextBox();
            tb33 = new System.Windows.Forms.TextBox();
            tbAngleOzOCS = new System.Windows.Forms.TextBox();
            tbAngleOyOCS = new System.Windows.Forms.TextBox();
            tbAngleOxOCS = new System.Windows.Forms.TextBox();
            tbAngleOzGCS = new System.Windows.Forms.TextBox();
            tbAngleOyGCS = new System.Windows.Forms.TextBox();
            tbAngleOxGCS = new System.Windows.Forms.TextBox();
            bDist = new System.Windows.Forms.Button();
            lbDist = new System.Windows.Forms.Label();
            numUDDist = new System.Windows.Forms.NumericUpDown();
            bResetAffine = new System.Windows.Forms.Button();
            bResetPicture = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            rbNone = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            rbNo = new System.Windows.Forms.RadioButton();
            rbYes = new System.Windows.Forms.RadioButton();
            label18 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAngleOx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAngleOy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbAngleOz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGlobalCoordsOz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGlobalCoordsOy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGlobalCoordsOx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDTranslateOz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDTranslateOy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDTranslateOx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDScale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDDist).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.Location = new System.Drawing.Point(9, 8);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(787, 645);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // tbAngleOx
            // 
            tbAngleOx.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tbAngleOx.Location = new System.Drawing.Point(898, 38);
            tbAngleOx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbAngleOx.Maximum = 180;
            tbAngleOx.Minimum = -180;
            tbAngleOx.Name = "tbAngleOx";
            tbAngleOx.Size = new System.Drawing.Size(187, 45);
            tbAngleOx.TabIndex = 1;
            tbAngleOx.TickStyle = System.Windows.Forms.TickStyle.None;
            tbAngleOx.ValueChanged += tbObjectAngles_ValueChanged;
            // 
            // tbAngleOy
            // 
            tbAngleOy.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tbAngleOy.Location = new System.Drawing.Point(898, 62);
            tbAngleOy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbAngleOy.Maximum = 180;
            tbAngleOy.Minimum = -180;
            tbAngleOy.Name = "tbAngleOy";
            tbAngleOy.Size = new System.Drawing.Size(187, 45);
            tbAngleOy.TabIndex = 2;
            tbAngleOy.TickStyle = System.Windows.Forms.TickStyle.None;
            tbAngleOy.ValueChanged += tbObjectAngles_ValueChanged;
            // 
            // tbAngleOz
            // 
            tbAngleOz.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tbAngleOz.Location = new System.Drawing.Point(898, 87);
            tbAngleOz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbAngleOz.Maximum = 180;
            tbAngleOz.Minimum = -180;
            tbAngleOz.Name = "tbAngleOz";
            tbAngleOz.Size = new System.Drawing.Size(187, 45);
            tbAngleOz.TabIndex = 3;
            tbAngleOz.TickStyle = System.Windows.Forms.TickStyle.None;
            tbAngleOz.ValueChanged += tbObjectAngles_ValueChanged;
            // 
            // tbGlobalCoordsOz
            // 
            tbGlobalCoordsOz.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tbGlobalCoordsOz.Location = new System.Drawing.Point(898, 209);
            tbGlobalCoordsOz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbGlobalCoordsOz.Maximum = 180;
            tbGlobalCoordsOz.Minimum = -180;
            tbGlobalCoordsOz.Name = "tbGlobalCoordsOz";
            tbGlobalCoordsOz.Size = new System.Drawing.Size(184, 45);
            tbGlobalCoordsOz.TabIndex = 6;
            tbGlobalCoordsOz.TickStyle = System.Windows.Forms.TickStyle.None;
            tbGlobalCoordsOz.ValueChanged += tbGlobalAngles_ValueChanged;
            // 
            // tbGlobalCoordsOy
            // 
            tbGlobalCoordsOy.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tbGlobalCoordsOy.Location = new System.Drawing.Point(898, 184);
            tbGlobalCoordsOy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbGlobalCoordsOy.Maximum = 180;
            tbGlobalCoordsOy.Minimum = -180;
            tbGlobalCoordsOy.Name = "tbGlobalCoordsOy";
            tbGlobalCoordsOy.Size = new System.Drawing.Size(184, 45);
            tbGlobalCoordsOy.TabIndex = 5;
            tbGlobalCoordsOy.TickStyle = System.Windows.Forms.TickStyle.None;
            tbGlobalCoordsOy.ValueChanged += tbGlobalAngles_ValueChanged;
            // 
            // tbGlobalCoordsOx
            // 
            tbGlobalCoordsOx.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tbGlobalCoordsOx.Location = new System.Drawing.Point(898, 158);
            tbGlobalCoordsOx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbGlobalCoordsOx.Maximum = 180;
            tbGlobalCoordsOx.Minimum = -180;
            tbGlobalCoordsOx.Name = "tbGlobalCoordsOx";
            tbGlobalCoordsOx.Size = new System.Drawing.Size(184, 45);
            tbGlobalCoordsOx.TabIndex = 4;
            tbGlobalCoordsOx.TickStyle = System.Windows.Forms.TickStyle.None;
            tbGlobalCoordsOx.ValueChanged += tbGlobalAngles_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(839, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(197, 15);
            label1.TabIndex = 13;
            label1.Text = "Rotation in object coodinate system";
            toolTip1.SetToolTip(label1, "Rotate the object in object's coodinate system around axis (counterclockwise direction)");
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(839, 137);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(185, 15);
            label2.TabIndex = 14;
            label2.Text = "Rotation of observer's perspective";
            toolTip1.SetToolTip(label2, "Rotate the observer's position in global coordinate system around axis (counterclockwise)");
            // 
            // numUDTranslateOz
            // 
            numUDTranslateOz.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numUDTranslateOz.Location = new System.Drawing.Point(847, 362);
            numUDTranslateOz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            numUDTranslateOz.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            numUDTranslateOz.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            numUDTranslateOz.Name = "numUDTranslateOz";
            numUDTranslateOz.Size = new System.Drawing.Size(58, 23);
            numUDTranslateOz.TabIndex = 17;
            // 
            // numUDTranslateOy
            // 
            numUDTranslateOy.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numUDTranslateOy.Location = new System.Drawing.Point(847, 320);
            numUDTranslateOy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            numUDTranslateOy.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            numUDTranslateOy.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            numUDTranslateOy.Name = "numUDTranslateOy";
            numUDTranslateOy.Size = new System.Drawing.Size(58, 23);
            numUDTranslateOy.TabIndex = 16;
            // 
            // numUDTranslateOx
            // 
            numUDTranslateOx.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numUDTranslateOx.Location = new System.Drawing.Point(847, 280);
            numUDTranslateOx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            numUDTranslateOx.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            numUDTranslateOx.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            numUDTranslateOx.Name = "numUDTranslateOx";
            numUDTranslateOx.Size = new System.Drawing.Size(58, 23);
            numUDTranslateOx.TabIndex = 15;
            // 
            // bTranslate
            // 
            bTranslate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            bTranslate.Location = new System.Drawing.Point(828, 388);
            bTranslate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            bTranslate.Name = "bTranslate";
            bTranslate.Size = new System.Drawing.Size(81, 22);
            bTranslate.TabIndex = 18;
            bTranslate.Text = "Translate";
            bTranslate.UseVisualStyleBackColor = true;
            bTranslate.Click += bTranslate_Click;
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(839, 258);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(53, 15);
            label11.TabIndex = 27;
            label11.Text = "Translate";
            toolTip1.SetToolTip(label11, "Translate the object to the point (in object coordinate system)");
            // 
            // label15
            // 
            label15.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(998, 339);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(45, 15);
            label15.TabIndex = 31;
            label15.Text = "Scaling";
            toolTip1.SetToolTip(label15, "Scale object relativly to object coordinate system");
            // 
            // label17
            // 
            label17.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(859, 422);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(158, 15);
            label17.TabIndex = 35;
            label17.Text = "Affine transformation matrix";
            toolTip1.SetToolTip(label17, "Current affine transformation matrix");
            // 
            // label19
            // 
            label19.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(962, 258);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(101, 15);
            label19.TabIndex = 58;
            label19.Text = "Observer distance";
            toolTip1.SetToolTip(label19, "Change the distance between the observer and center of object coordinate system");
            // 
            // rbProfile
            // 
            rbProfile.AutoSize = true;
            rbProfile.Location = new System.Drawing.Point(99, 20);
            rbProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rbProfile.Name = "rbProfile";
            rbProfile.Size = new System.Drawing.Size(59, 19);
            rbProfile.TabIndex = 2;
            rbProfile.Text = "profile";
            toolTip1.SetToolTip(rbProfile, "Oyz");
            rbProfile.UseVisualStyleBackColor = true;
            rbProfile.CheckedChanged += rbProfile_CheckedChanged;
            // 
            // rbHorizontal
            // 
            rbHorizontal.AutoSize = true;
            rbHorizontal.Location = new System.Drawing.Point(5, 42);
            rbHorizontal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rbHorizontal.Name = "rbHorizontal";
            rbHorizontal.Size = new System.Drawing.Size(78, 19);
            rbHorizontal.TabIndex = 1;
            rbHorizontal.Text = "horizontal";
            toolTip1.SetToolTip(rbHorizontal, "Oxy");
            rbHorizontal.UseVisualStyleBackColor = true;
            rbHorizontal.CheckedChanged += rbProfile_CheckedChanged;
            // 
            // rbFrontal
            // 
            rbFrontal.AutoSize = true;
            rbFrontal.Location = new System.Drawing.Point(5, 20);
            rbFrontal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rbFrontal.Name = "rbFrontal";
            rbFrontal.Size = new System.Drawing.Size(60, 19);
            rbFrontal.TabIndex = 0;
            rbFrontal.Text = "frontal";
            toolTip1.SetToolTip(rbFrontal, "Oxz");
            rbFrontal.UseVisualStyleBackColor = true;
            rbFrontal.CheckedChanged += rbProfile_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 15);
            label3.TabIndex = 19;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(802, 38);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 15);
            label4.TabIndex = 20;
            label4.Text = "Ox (α)";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(802, 62);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(40, 15);
            label5.TabIndex = 21;
            label5.Text = "Oy (β)";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(802, 86);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(38, 15);
            label6.TabIndex = 22;
            label6.Text = "Oz (γ)";
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(802, 207);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(38, 15);
            label7.TabIndex = 26;
            label7.Text = "Oz (γ)";
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(802, 184);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(40, 15);
            label8.TabIndex = 25;
            label8.Text = "Oy (β)";
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(802, 160);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(40, 15);
            label9.TabIndex = 24;
            label9.Text = "Ox (α)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(4, 151);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(0, 15);
            label10.TabIndex = 23;
            // 
            // label12
            // 
            label12.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(828, 362);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(12, 15);
            label12.TabIndex = 30;
            label12.Text = "z";
            // 
            // label13
            // 
            label13.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(828, 322);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(13, 15);
            label13.TabIndex = 29;
            label13.Text = "y";
            // 
            // label14
            // 
            label14.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(828, 280);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(13, 15);
            label14.TabIndex = 28;
            label14.Text = "x";
            // 
            // numUDScale
            // 
            numUDScale.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numUDScale.DecimalPlaces = 2;
            numUDScale.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numUDScale.Location = new System.Drawing.Point(1005, 362);
            numUDScale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            numUDScale.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numUDScale.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numUDScale.Name = "numUDScale";
            numUDScale.Size = new System.Drawing.Size(67, 23);
            numUDScale.TabIndex = 32;
            numUDScale.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label16
            // 
            label16.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(962, 364);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(34, 15);
            label16.TabIndex = 33;
            label16.Text = "Scale";
            // 
            // bScale
            // 
            bScale.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            bScale.Location = new System.Drawing.Point(962, 388);
            bScale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            bScale.Name = "bScale";
            bScale.Size = new System.Drawing.Size(111, 22);
            bScale.TabIndex = 34;
            bScale.Text = "Change scale";
            bScale.UseVisualStyleBackColor = true;
            bScale.Click += bScale_Click;
            // 
            // tb00
            // 
            tb00.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb00.Location = new System.Drawing.Point(816, 448);
            tb00.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb00.MaxLength = 7;
            tb00.Name = "tb00";
            tb00.ReadOnly = true;
            tb00.Size = new System.Drawing.Size(62, 23);
            tb00.TabIndex = 36;
            // 
            // tb10
            // 
            tb10.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb10.Location = new System.Drawing.Point(816, 472);
            tb10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb10.MaxLength = 7;
            tb10.Name = "tb10";
            tb10.ReadOnly = true;
            tb10.Size = new System.Drawing.Size(62, 23);
            tb10.TabIndex = 37;
            // 
            // tb20
            // 
            tb20.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb20.Location = new System.Drawing.Point(816, 497);
            tb20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb20.MaxLength = 7;
            tb20.Name = "tb20";
            tb20.ReadOnly = true;
            tb20.Size = new System.Drawing.Size(62, 23);
            tb20.TabIndex = 38;
            // 
            // tb30
            // 
            tb30.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb30.Location = new System.Drawing.Point(816, 522);
            tb30.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb30.MaxLength = 7;
            tb30.Name = "tb30";
            tb30.ReadOnly = true;
            tb30.Size = new System.Drawing.Size(62, 23);
            tb30.TabIndex = 39;
            // 
            // tb01
            // 
            tb01.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb01.Location = new System.Drawing.Point(883, 448);
            tb01.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb01.MaxLength = 7;
            tb01.Name = "tb01";
            tb01.ReadOnly = true;
            tb01.Size = new System.Drawing.Size(62, 23);
            tb01.TabIndex = 40;
            // 
            // tb11
            // 
            tb11.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb11.Location = new System.Drawing.Point(883, 472);
            tb11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb11.MaxLength = 7;
            tb11.Name = "tb11";
            tb11.ReadOnly = true;
            tb11.Size = new System.Drawing.Size(62, 23);
            tb11.TabIndex = 41;
            // 
            // tb21
            // 
            tb21.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb21.Location = new System.Drawing.Point(883, 497);
            tb21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb21.MaxLength = 7;
            tb21.Name = "tb21";
            tb21.ReadOnly = true;
            tb21.Size = new System.Drawing.Size(62, 23);
            tb21.TabIndex = 42;
            // 
            // tb31
            // 
            tb31.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb31.Location = new System.Drawing.Point(883, 522);
            tb31.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb31.MaxLength = 7;
            tb31.Name = "tb31";
            tb31.ReadOnly = true;
            tb31.Size = new System.Drawing.Size(62, 23);
            tb31.TabIndex = 43;
            // 
            // tb02
            // 
            tb02.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb02.Location = new System.Drawing.Point(949, 448);
            tb02.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb02.MaxLength = 7;
            tb02.Name = "tb02";
            tb02.ReadOnly = true;
            tb02.Size = new System.Drawing.Size(62, 23);
            tb02.TabIndex = 44;
            // 
            // tb12
            // 
            tb12.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb12.Location = new System.Drawing.Point(949, 472);
            tb12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb12.MaxLength = 7;
            tb12.Name = "tb12";
            tb12.ReadOnly = true;
            tb12.Size = new System.Drawing.Size(62, 23);
            tb12.TabIndex = 45;
            // 
            // tb22
            // 
            tb22.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb22.Location = new System.Drawing.Point(949, 497);
            tb22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb22.MaxLength = 7;
            tb22.Name = "tb22";
            tb22.ReadOnly = true;
            tb22.Size = new System.Drawing.Size(62, 23);
            tb22.TabIndex = 46;
            // 
            // tb32
            // 
            tb32.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb32.Location = new System.Drawing.Point(949, 522);
            tb32.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb32.MaxLength = 7;
            tb32.Name = "tb32";
            tb32.ReadOnly = true;
            tb32.Size = new System.Drawing.Size(62, 23);
            tb32.TabIndex = 47;
            // 
            // tb03
            // 
            tb03.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb03.Location = new System.Drawing.Point(1016, 448);
            tb03.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb03.MaxLength = 7;
            tb03.Name = "tb03";
            tb03.ReadOnly = true;
            tb03.Size = new System.Drawing.Size(62, 23);
            tb03.TabIndex = 48;
            // 
            // tb13
            // 
            tb13.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb13.Location = new System.Drawing.Point(1016, 472);
            tb13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb13.MaxLength = 7;
            tb13.Name = "tb13";
            tb13.ReadOnly = true;
            tb13.Size = new System.Drawing.Size(62, 23);
            tb13.TabIndex = 49;
            // 
            // tb23
            // 
            tb23.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb23.Location = new System.Drawing.Point(1016, 497);
            tb23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb23.MaxLength = 7;
            tb23.Name = "tb23";
            tb23.ReadOnly = true;
            tb23.Size = new System.Drawing.Size(62, 23);
            tb23.TabIndex = 50;
            // 
            // tb33
            // 
            tb33.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tb33.Location = new System.Drawing.Point(1016, 522);
            tb33.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb33.MaxLength = 7;
            tb33.Name = "tb33";
            tb33.ReadOnly = true;
            tb33.Size = new System.Drawing.Size(62, 23);
            tb33.TabIndex = 51;
            // 
            // tbAngleOzOCS
            // 
            tbAngleOzOCS.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tbAngleOzOCS.Location = new System.Drawing.Point(851, 87);
            tbAngleOzOCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbAngleOzOCS.MaxLength = 7;
            tbAngleOzOCS.Name = "tbAngleOzOCS";
            tbAngleOzOCS.ReadOnly = true;
            tbAngleOzOCS.Size = new System.Drawing.Size(42, 23);
            tbAngleOzOCS.TabIndex = 54;
            tbAngleOzOCS.Text = "0°";
            // 
            // tbAngleOyOCS
            // 
            tbAngleOyOCS.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tbAngleOyOCS.Location = new System.Drawing.Point(851, 62);
            tbAngleOyOCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbAngleOyOCS.MaxLength = 7;
            tbAngleOyOCS.Name = "tbAngleOyOCS";
            tbAngleOyOCS.ReadOnly = true;
            tbAngleOyOCS.Size = new System.Drawing.Size(42, 23);
            tbAngleOyOCS.TabIndex = 53;
            tbAngleOyOCS.Text = "0°";
            // 
            // tbAngleOxOCS
            // 
            tbAngleOxOCS.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tbAngleOxOCS.Location = new System.Drawing.Point(851, 38);
            tbAngleOxOCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbAngleOxOCS.MaxLength = 7;
            tbAngleOxOCS.Name = "tbAngleOxOCS";
            tbAngleOxOCS.ReadOnly = true;
            tbAngleOxOCS.Size = new System.Drawing.Size(42, 23);
            tbAngleOxOCS.TabIndex = 52;
            tbAngleOxOCS.Text = "0°";
            // 
            // tbAngleOzGCS
            // 
            tbAngleOzGCS.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tbAngleOzGCS.Location = new System.Drawing.Point(851, 208);
            tbAngleOzGCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbAngleOzGCS.MaxLength = 7;
            tbAngleOzGCS.Name = "tbAngleOzGCS";
            tbAngleOzGCS.ReadOnly = true;
            tbAngleOzGCS.Size = new System.Drawing.Size(42, 23);
            tbAngleOzGCS.TabIndex = 57;
            tbAngleOzGCS.Text = "0°";
            // 
            // tbAngleOyGCS
            // 
            tbAngleOyGCS.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tbAngleOyGCS.Location = new System.Drawing.Point(851, 183);
            tbAngleOyGCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbAngleOyGCS.MaxLength = 7;
            tbAngleOyGCS.Name = "tbAngleOyGCS";
            tbAngleOyGCS.ReadOnly = true;
            tbAngleOyGCS.Size = new System.Drawing.Size(42, 23);
            tbAngleOyGCS.TabIndex = 56;
            tbAngleOyGCS.Text = "0°";
            // 
            // tbAngleOxGCS
            // 
            tbAngleOxGCS.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tbAngleOxGCS.Location = new System.Drawing.Point(851, 158);
            tbAngleOxGCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbAngleOxGCS.MaxLength = 7;
            tbAngleOxGCS.Name = "tbAngleOxGCS";
            tbAngleOxGCS.ReadOnly = true;
            tbAngleOxGCS.Size = new System.Drawing.Size(42, 23);
            tbAngleOxGCS.TabIndex = 55;
            tbAngleOxGCS.Text = "0°";
            // 
            // bDist
            // 
            bDist.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            bDist.Location = new System.Drawing.Point(962, 308);
            bDist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            bDist.Name = "bDist";
            bDist.Size = new System.Drawing.Size(111, 22);
            bDist.TabIndex = 61;
            bDist.Text = "Change distance";
            bDist.UseVisualStyleBackColor = true;
            bDist.Click += bDist_Click;
            // 
            // lbDist
            // 
            lbDist.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lbDist.AutoSize = true;
            lbDist.Location = new System.Drawing.Point(942, 282);
            lbDist.Name = "lbDist";
            lbDist.Size = new System.Drawing.Size(52, 15);
            lbDist.TabIndex = 60;
            lbDist.Text = "Distance";
            // 
            // numUDDist
            // 
            numUDDist.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numUDDist.DecimalPlaces = 2;
            numUDDist.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numUDDist.Location = new System.Drawing.Point(1005, 280);
            numUDDist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            numUDDist.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numUDDist.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numUDDist.Name = "numUDDist";
            numUDDist.Size = new System.Drawing.Size(67, 23);
            numUDDist.TabIndex = 59;
            numUDDist.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // bResetAffine
            // 
            bResetAffine.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            bResetAffine.Location = new System.Drawing.Point(816, 550);
            bResetAffine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            bResetAffine.Name = "bResetAffine";
            bResetAffine.Size = new System.Drawing.Size(116, 37);
            bResetAffine.TabIndex = 62;
            bResetAffine.Text = "Reset affine transformation";
            bResetAffine.UseVisualStyleBackColor = true;
            bResetAffine.Click += bResetAffine_Click;
            // 
            // bResetPicture
            // 
            bResetPicture.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            bResetPicture.Location = new System.Drawing.Point(962, 550);
            bResetPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            bResetPicture.Name = "bResetPicture";
            bResetPicture.Size = new System.Drawing.Size(116, 37);
            bResetPicture.TabIndex = 63;
            bResetPicture.Text = "Reset observer's position";
            bResetPicture.UseVisualStyleBackColor = true;
            bResetPicture.Click += bResetPicture_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(rbNone);
            groupBox1.Controls.Add(rbProfile);
            groupBox1.Controls.Add(rbHorizontal);
            groupBox1.Controls.Add(rbFrontal);
            groupBox1.Location = new System.Drawing.Point(816, 592);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Size = new System.Drawing.Size(168, 66);
            groupBox1.TabIndex = 65;
            groupBox1.TabStop = false;
            groupBox1.Text = "Projections";
            // 
            // rbNone
            // 
            rbNone.AutoSize = true;
            rbNone.Checked = true;
            rbNone.Location = new System.Drawing.Point(99, 42);
            rbNone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rbNone.Name = "rbNone";
            rbNone.Size = new System.Drawing.Size(52, 19);
            rbNone.TabIndex = 3;
            rbNone.TabStop = true;
            rbNone.Text = "none";
            rbNone.UseVisualStyleBackColor = true;
            rbNone.CheckedChanged += rbProfile_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(rbNo);
            groupBox2.Controls.Add(rbYes);
            groupBox2.Location = new System.Drawing.Point(998, 592);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Size = new System.Drawing.Size(88, 66);
            groupBox2.TabIndex = 66;
            groupBox2.TabStop = false;
            groupBox2.Text = "Show GCS";
            // 
            // rbNo
            // 
            rbNo.AutoSize = true;
            rbNo.Location = new System.Drawing.Point(18, 42);
            rbNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rbNo.Name = "rbNo";
            rbNo.Size = new System.Drawing.Size(39, 19);
            rbNo.TabIndex = 4;
            rbNo.Text = "no";
            rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            rbYes.AutoSize = true;
            rbYes.Checked = true;
            rbYes.Location = new System.Drawing.Point(18, 20);
            rbYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rbYes.Name = "rbYes";
            rbYes.Size = new System.Drawing.Size(42, 19);
            rbYes.TabIndex = 3;
            rbYes.TabStop = true;
            rbYes.Text = "yes";
            rbYes.UseVisualStyleBackColor = true;
            rbYes.CheckedChanged += rbYes_CheckedChanged;
            // 
            // label18
            // 
            label18.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label18.ForeColor = System.Drawing.Color.Red;
            label18.Location = new System.Drawing.Point(822, 111);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(238, 13);
            label18.TabIndex = 67;
            label18.Text = "Warning: possible accumulation of rotation error";
            // 
            // label20
            // 
            label20.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label20.ForeColor = System.Drawing.Color.Red;
            label20.Location = new System.Drawing.Point(822, 230);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(238, 13);
            label20.TabIndex = 68;
            label20.Text = "Warning: possible accumulation of rotation error";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1096, 668);
            Controls.Add(label20);
            Controls.Add(label18);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(bResetPicture);
            Controls.Add(bResetAffine);
            Controls.Add(bDist);
            Controls.Add(lbDist);
            Controls.Add(numUDDist);
            Controls.Add(label19);
            Controls.Add(tbAngleOzGCS);
            Controls.Add(tbAngleOyGCS);
            Controls.Add(tbAngleOxGCS);
            Controls.Add(tbAngleOzOCS);
            Controls.Add(tbAngleOyOCS);
            Controls.Add(tbAngleOxOCS);
            Controls.Add(tb33);
            Controls.Add(tb23);
            Controls.Add(tb13);
            Controls.Add(tb03);
            Controls.Add(tb32);
            Controls.Add(tb22);
            Controls.Add(tb12);
            Controls.Add(tb02);
            Controls.Add(tb31);
            Controls.Add(tb21);
            Controls.Add(tb11);
            Controls.Add(tb01);
            Controls.Add(tb30);
            Controls.Add(tb20);
            Controls.Add(tb10);
            Controls.Add(tb00);
            Controls.Add(label17);
            Controls.Add(bScale);
            Controls.Add(label16);
            Controls.Add(numUDScale);
            Controls.Add(label15);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(bTranslate);
            Controls.Add(numUDTranslateOz);
            Controls.Add(numUDTranslateOy);
            Controls.Add(numUDTranslateOx);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbGlobalCoordsOz);
            Controls.Add(tbGlobalCoordsOy);
            Controls.Add(tbGlobalCoordsOx);
            Controls.Add(tbAngleOz);
            Controls.Add(tbAngleOy);
            Controls.Add(tbAngleOx);
            Controls.Add(pictureBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MinimumSize = new System.Drawing.Size(352, 707);
            Name = "Form1";
            Text = "Affine Transformation Application";
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAngleOx).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAngleOy).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbAngleOz).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGlobalCoordsOz).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGlobalCoordsOy).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGlobalCoordsOx).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDTranslateOz).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDTranslateOy).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDTranslateOx).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDScale).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDDist).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar tbAngleOx;
        private System.Windows.Forms.TrackBar tbAngleOy;
        private System.Windows.Forms.TrackBar tbAngleOz;
        private System.Windows.Forms.TrackBar tbGlobalCoordsOz;
        private System.Windows.Forms.TrackBar tbGlobalCoordsOy;
        private System.Windows.Forms.TrackBar tbGlobalCoordsOx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUDTranslateOz;
        private System.Windows.Forms.NumericUpDown numUDTranslateOy;
        private System.Windows.Forms.NumericUpDown numUDTranslateOx;
        private System.Windows.Forms.Button bTranslate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numUDScale;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button bScale;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb00;
        private System.Windows.Forms.TextBox tb10;
        private System.Windows.Forms.TextBox tb20;
        private System.Windows.Forms.TextBox tb30;
        private System.Windows.Forms.TextBox tb01;
        private System.Windows.Forms.TextBox tb11;
        private System.Windows.Forms.TextBox tb21;
        private System.Windows.Forms.TextBox tb31;
        private System.Windows.Forms.TextBox tb02;
        private System.Windows.Forms.TextBox tb12;
        private System.Windows.Forms.TextBox tb22;
        private System.Windows.Forms.TextBox tb32;
        private System.Windows.Forms.TextBox tb03;
        private System.Windows.Forms.TextBox tb13;
        private System.Windows.Forms.TextBox tb23;
        private System.Windows.Forms.TextBox tb33;
        private System.Windows.Forms.TextBox tbAngleOzOCS;
        private System.Windows.Forms.TextBox tbAngleOyOCS;
        private System.Windows.Forms.TextBox tbAngleOxOCS;
        private System.Windows.Forms.TextBox tbAngleOzGCS;
        private System.Windows.Forms.TextBox tbAngleOyGCS;
        private System.Windows.Forms.TextBox tbAngleOxGCS;
        private System.Windows.Forms.Button bDist;
        private System.Windows.Forms.Label lbDist;
        private System.Windows.Forms.NumericUpDown numUDDist;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button bResetAffine;
        private System.Windows.Forms.Button bResetPicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbProfile;
        private System.Windows.Forms.RadioButton rbHorizontal;
        private System.Windows.Forms.RadioButton rbFrontal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
    }
}

