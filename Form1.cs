namespace SimplePaint
{
    public partial class Form1 : Form
    {
        enum ToolType { Line, Rectangle, Circle }

        private ToolType currentTool = ToolType.Line;
        private Color currentColor = Color.Black;
        private int currentLineWidth = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbColor.SelectedItem.ToString())
            {
                case "Black": currentColor = Color.Black; break;
                case "Red": currentColor = Color.Red; break;
                case "Blue": currentColor = Color.Blue; break;
                case "Green": currentColor = Color.Green; break;
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Line;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbColor.Items.Add("Black");
            cmbColor.Items.Add("Red");
            cmbColor.Items.Add("Blue");
            cmbColor.Items.Add("Green");

            cmbColor.SelectedIndex = 0;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Rectangle;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Circle;
        }

        private void trbLineWidth_Scroll(object sender, EventArgs e)
        {
            currentLineWidth = trbLineWidth.Value;
        }
    }
}
