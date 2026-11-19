namespace Pizza_Project
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMakeYourPizza = new System.Windows.Forms.Label();
            this.pnSize = new System.Windows.Forms.Panel();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.lbSize = new System.Windows.Forms.Label();
            this.pnCrustType = new System.Windows.Forms.Panel();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.pnToppings = new System.Windows.Forms.Panel();
            this.chbGreenPapers = new System.Windows.Forms.CheckBox();
            this.chbOlives = new System.Windows.Forms.CheckBox();
            this.chbOnion = new System.Windows.Forms.CheckBox();
            this.chbTomatoes = new System.Windows.Forms.CheckBox();
            this.chbMushrooms = new System.Windows.Forms.CheckBox();
            this.chbExtraChees = new System.Windows.Forms.CheckBox();
            this.lbToppings = new System.Windows.Forms.Label();
            this.pnWhereToEat = new System.Windows.Forms.Panel();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.lbOrderSummary = new System.Windows.Forms.Label();
            this.slbSize = new System.Windows.Forms.Label();
            this.slbToppings = new System.Windows.Forms.Label();
            this.slbCrustType = new System.Windows.Forms.Label();
            this.slbWhereToEat = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.pnSize.SuspendLayout();
            this.pnCrustType.SuspendLayout();
            this.pnToppings.SuspendLayout();
            this.pnWhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMakeYourPizza
            // 
            this.lbMakeYourPizza.AutoSize = true;
            this.lbMakeYourPizza.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMakeYourPizza.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMakeYourPizza.ForeColor = System.Drawing.Color.Red;
            this.lbMakeYourPizza.Location = new System.Drawing.Point(330, -3);
            this.lbMakeYourPizza.Name = "lbMakeYourPizza";
            this.lbMakeYourPizza.Size = new System.Drawing.Size(620, 95);
            this.lbMakeYourPizza.TabIndex = 0;
            this.lbMakeYourPizza.Text = "Make Your Pizza";
            // 
            // pnSize
            // 
            this.pnSize.Controls.Add(this.rbLarg);
            this.pnSize.Controls.Add(this.rbMedium);
            this.pnSize.Controls.Add(this.rbSmall);
            this.pnSize.Controls.Add(this.lbSize);
            this.pnSize.Location = new System.Drawing.Point(52, 112);
            this.pnSize.Name = "pnSize";
            this.pnSize.Size = new System.Drawing.Size(261, 244);
            this.pnSize.TabIndex = 1;
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbLarg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarg.ForeColor = System.Drawing.SystemColors.Control;
            this.rbLarg.Location = new System.Drawing.Point(67, 159);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(80, 29);
            this.rbLarg.TabIndex = 3;
            this.rbLarg.TabStop = true;
            this.rbLarg.Tag = "15";
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = false;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.ForeColor = System.Drawing.SystemColors.Control;
            this.rbMedium.Location = new System.Drawing.Point(67, 113);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(113, 29);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "10";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = false;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.ForeColor = System.Drawing.SystemColors.Control;
            this.rbSmall.Location = new System.Drawing.Point(67, 67);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(91, 29);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "5";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = false;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSize.Location = new System.Drawing.Point(26, 13);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(74, 32);
            this.lbSize.TabIndex = 0;
            this.lbSize.Text = "Size";
            // 
            // pnCrustType
            // 
            this.pnCrustType.Controls.Add(this.rbThinkCrust);
            this.pnCrustType.Controls.Add(this.rbThinCrust);
            this.pnCrustType.Controls.Add(this.lbCrustType);
            this.pnCrustType.Location = new System.Drawing.Point(52, 423);
            this.pnCrustType.Name = "pnCrustType";
            this.pnCrustType.Size = new System.Drawing.Size(261, 244);
            this.pnCrustType.TabIndex = 4;
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbThinkCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinkCrust.ForeColor = System.Drawing.SystemColors.Control;
            this.rbThinkCrust.Location = new System.Drawing.Point(67, 125);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(149, 29);
            this.rbThinkCrust.TabIndex = 3;
            this.rbThinkCrust.TabStop = true;
            this.rbThinkCrust.Tag = "15";
            this.rbThinkCrust.Text = "Think Crust";
            this.rbThinkCrust.UseVisualStyleBackColor = false;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbThinCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinCrust.ForeColor = System.Drawing.SystemColors.Control;
            this.rbThinCrust.Location = new System.Drawing.Point(67, 80);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(138, 29);
            this.rbThinCrust.TabIndex = 1;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "10";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = false;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCrustType.Location = new System.Drawing.Point(26, 22);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(161, 32);
            this.lbCrustType.TabIndex = 0;
            this.lbCrustType.Text = "Crust Type";
            // 
            // pnToppings
            // 
            this.pnToppings.Controls.Add(this.chbGreenPapers);
            this.pnToppings.Controls.Add(this.chbOlives);
            this.pnToppings.Controls.Add(this.chbOnion);
            this.pnToppings.Controls.Add(this.chbTomatoes);
            this.pnToppings.Controls.Add(this.chbMushrooms);
            this.pnToppings.Controls.Add(this.chbExtraChees);
            this.pnToppings.Controls.Add(this.lbToppings);
            this.pnToppings.Location = new System.Drawing.Point(415, 112);
            this.pnToppings.Name = "pnToppings";
            this.pnToppings.Size = new System.Drawing.Size(488, 244);
            this.pnToppings.TabIndex = 4;
            // 
            // chbGreenPapers
            // 
            this.chbGreenPapers.AutoSize = true;
            this.chbGreenPapers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chbGreenPapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGreenPapers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chbGreenPapers.Location = new System.Drawing.Point(206, 164);
            this.chbGreenPapers.Name = "chbGreenPapers";
            this.chbGreenPapers.Size = new System.Drawing.Size(146, 24);
            this.chbGreenPapers.TabIndex = 6;
            this.chbGreenPapers.Tag = "5";
            this.chbGreenPapers.Text = "Green Papers";
            this.chbGreenPapers.UseVisualStyleBackColor = false;
            this.chbGreenPapers.CheckedChanged += new System.EventHandler(this.chbGreenPapers_CheckedChanged);
            // 
            // chbOlives
            // 
            this.chbOlives.AutoSize = true;
            this.chbOlives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chbOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbOlives.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chbOlives.Location = new System.Drawing.Point(206, 118);
            this.chbOlives.Name = "chbOlives";
            this.chbOlives.Size = new System.Drawing.Size(83, 24);
            this.chbOlives.TabIndex = 5;
            this.chbOlives.Tag = "10";
            this.chbOlives.Text = "Olives";
            this.chbOlives.UseVisualStyleBackColor = false;
            this.chbOlives.CheckedChanged += new System.EventHandler(this.chbOlives_CheckedChanged);
            // 
            // chbOnion
            // 
            this.chbOnion.AutoSize = true;
            this.chbOnion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chbOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbOnion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chbOnion.Location = new System.Drawing.Point(206, 72);
            this.chbOnion.Name = "chbOnion";
            this.chbOnion.Size = new System.Drawing.Size(82, 24);
            this.chbOnion.TabIndex = 4;
            this.chbOnion.Tag = "5";
            this.chbOnion.Text = "Onion";
            this.chbOnion.UseVisualStyleBackColor = false;
            this.chbOnion.CheckedChanged += new System.EventHandler(this.chbOnion_CheckedChanged);
            // 
            // chbTomatoes
            // 
            this.chbTomatoes.AutoSize = true;
            this.chbTomatoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chbTomatoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTomatoes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chbTomatoes.Location = new System.Drawing.Point(31, 164);
            this.chbTomatoes.Name = "chbTomatoes";
            this.chbTomatoes.Size = new System.Drawing.Size(114, 24);
            this.chbTomatoes.TabIndex = 3;
            this.chbTomatoes.Tag = "5";
            this.chbTomatoes.Text = "Tomatoes";
            this.chbTomatoes.UseVisualStyleBackColor = false;
            this.chbTomatoes.CheckedChanged += new System.EventHandler(this.chbTomatoes_CheckedChanged);
            // 
            // chbMushrooms
            // 
            this.chbMushrooms.AutoSize = true;
            this.chbMushrooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chbMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMushrooms.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chbMushrooms.Location = new System.Drawing.Point(31, 118);
            this.chbMushrooms.Name = "chbMushrooms";
            this.chbMushrooms.Size = new System.Drawing.Size(127, 24);
            this.chbMushrooms.TabIndex = 2;
            this.chbMushrooms.Tag = "5";
            this.chbMushrooms.Text = "Mushrooms";
            this.chbMushrooms.UseVisualStyleBackColor = false;
            this.chbMushrooms.CheckedChanged += new System.EventHandler(this.chbMushrooms_CheckedChanged);
            // 
            // chbExtraChees
            // 
            this.chbExtraChees.AutoSize = true;
            this.chbExtraChees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chbExtraChees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbExtraChees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chbExtraChees.Location = new System.Drawing.Point(31, 71);
            this.chbExtraChees.Name = "chbExtraChees";
            this.chbExtraChees.Size = new System.Drawing.Size(133, 24);
            this.chbExtraChees.TabIndex = 1;
            this.chbExtraChees.Tag = "5";
            this.chbExtraChees.Text = "Extra Chees";
            this.chbExtraChees.UseVisualStyleBackColor = false;
            this.chbExtraChees.CheckedChanged += new System.EventHandler(this.chbExtraChees_CheckedChanged);
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbToppings.Location = new System.Drawing.Point(25, 13);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(140, 32);
            this.lbToppings.TabIndex = 0;
            this.lbToppings.Text = "Toppings";
            // 
            // pnWhereToEat
            // 
            this.pnWhereToEat.Controls.Add(this.rbTakeOut);
            this.pnWhereToEat.Controls.Add(this.rbEatIn);
            this.pnWhereToEat.Controls.Add(this.lbWhereToEat);
            this.pnWhereToEat.Location = new System.Drawing.Point(415, 423);
            this.pnWhereToEat.Name = "pnWhereToEat";
            this.pnWhereToEat.Size = new System.Drawing.Size(446, 187);
            this.pnWhereToEat.TabIndex = 5;
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbTakeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeOut.ForeColor = System.Drawing.SystemColors.Control;
            this.rbTakeOut.Location = new System.Drawing.Point(225, 104);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(127, 29);
            this.rbTakeOut.TabIndex = 3;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = false;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.ForeColor = System.Drawing.SystemColors.Control;
            this.rbEatIn.Location = new System.Drawing.Point(73, 104);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(92, 29);
            this.rbEatIn.TabIndex = 1;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat in";
            this.rbEatIn.UseVisualStyleBackColor = false;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbWhereToEat.Location = new System.Drawing.Point(29, 44);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(157, 26);
            this.lbWhereToEat.TabIndex = 0;
            this.lbWhereToEat.Text = "Where To Eat";
            // 
            // lbOrderSummary
            // 
            this.lbOrderSummary.AutoSize = true;
            this.lbOrderSummary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderSummary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbOrderSummary.Location = new System.Drawing.Point(918, 125);
            this.lbOrderSummary.Name = "lbOrderSummary";
            this.lbOrderSummary.Size = new System.Drawing.Size(196, 29);
            this.lbOrderSummary.TabIndex = 6;
            this.lbOrderSummary.Text = "Order Summary";
            // 
            // slbSize
            // 
            this.slbSize.AutoSize = true;
            this.slbSize.BackColor = System.Drawing.Color.Black;
            this.slbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slbSize.ForeColor = System.Drawing.Color.White;
            this.slbSize.Location = new System.Drawing.Point(978, 194);
            this.slbSize.Name = "slbSize";
            this.slbSize.Size = new System.Drawing.Size(150, 25);
            this.slbSize.TabIndex = 7;
            this.slbSize.Text = "Size : Medium";
            // 
            // slbToppings
            // 
            this.slbToppings.AutoSize = true;
            this.slbToppings.BackColor = System.Drawing.Color.Black;
            this.slbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slbToppings.ForeColor = System.Drawing.Color.White;
            this.slbToppings.Location = new System.Drawing.Point(978, 250);
            this.slbToppings.Name = "slbToppings";
            this.slbToppings.Size = new System.Drawing.Size(102, 25);
            this.slbToppings.TabIndex = 8;
            this.slbToppings.Text = "Toppings";
            // 
            // slbCrustType
            // 
            this.slbCrustType.AutoSize = true;
            this.slbCrustType.BackColor = System.Drawing.Color.Black;
            this.slbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slbCrustType.ForeColor = System.Drawing.Color.White;
            this.slbCrustType.Location = new System.Drawing.Point(978, 467);
            this.slbCrustType.Name = "slbCrustType";
            this.slbCrustType.Size = new System.Drawing.Size(119, 25);
            this.slbCrustType.TabIndex = 9;
            this.slbCrustType.Text = "Crust Type";
            // 
            // slbWhereToEat
            // 
            this.slbWhereToEat.AutoSize = true;
            this.slbWhereToEat.BackColor = System.Drawing.Color.Black;
            this.slbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slbWhereToEat.ForeColor = System.Drawing.Color.White;
            this.slbWhereToEat.Location = new System.Drawing.Point(978, 507);
            this.slbWhereToEat.Name = "slbWhereToEat";
            this.slbWhereToEat.Size = new System.Drawing.Size(146, 25);
            this.slbWhereToEat.TabIndex = 10;
            this.slbWhereToEat.Text = "Where To Eat";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrderPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrderPizza.Location = new System.Drawing.Point(346, 676);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(188, 63);
            this.btnOrderPizza.TabIndex = 11;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResetForm.Location = new System.Drawing.Point(579, 676);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(188, 63);
            this.btnResetForm.TabIndex = 12;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotalPrice.Location = new System.Drawing.Point(919, 572);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(141, 29);
            this.lbTotalPrice.TabIndex = 13;
            this.lbTotalPrice.Text = "Total Price";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbPrice.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Lime;
            this.lbPrice.Location = new System.Drawing.Point(923, 634);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(205, 95);
            this.lbPrice.TabIndex = 14;
            this.lbPrice.Text = "Price";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Project.Properties.Resources.pepperoni_pizza_on_the_wooden_board_with_dark_lighting_and_black_background_food_and_delivery_concept_generative_ai_free_photo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1295, 780);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.slbWhereToEat);
            this.Controls.Add(this.slbCrustType);
            this.Controls.Add(this.slbToppings);
            this.Controls.Add(this.slbSize);
            this.Controls.Add(this.lbOrderSummary);
            this.Controls.Add(this.pnWhereToEat);
            this.Controls.Add(this.pnToppings);
            this.Controls.Add(this.pnCrustType);
            this.Controls.Add(this.pnSize);
            this.Controls.Add(this.lbMakeYourPizza);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pnSize.ResumeLayout(false);
            this.pnSize.PerformLayout();
            this.pnCrustType.ResumeLayout(false);
            this.pnCrustType.PerformLayout();
            this.pnToppings.ResumeLayout(false);
            this.pnToppings.PerformLayout();
            this.pnWhereToEat.ResumeLayout(false);
            this.pnWhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMakeYourPizza;
        private System.Windows.Forms.Panel pnSize;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Panel pnCrustType;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Panel pnToppings;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.CheckBox chbGreenPapers;
        private System.Windows.Forms.CheckBox chbOlives;
        private System.Windows.Forms.CheckBox chbOnion;
        private System.Windows.Forms.CheckBox chbTomatoes;
        private System.Windows.Forms.CheckBox chbMushrooms;
        private System.Windows.Forms.CheckBox chbExtraChees;
        private System.Windows.Forms.Panel pnWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.Label lbOrderSummary;
        private System.Windows.Forms.Label slbSize;
        private System.Windows.Forms.Label slbToppings;
        private System.Windows.Forms.Label slbCrustType;
        private System.Windows.Forms.Label slbWhereToEat;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbPrice;
    }
}

