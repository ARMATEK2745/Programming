using Programming.Model.Geometry;
using Programming.Model;

namespace Programming.View
{
    public partial class RectanglesParametersUserControl : UserControl
    {
        private Rectangles _currentRectangle;
        private List<Rectangles> _rectangles = new List<Rectangles>();
        private List<Panel> _rectanglePanels = new List<Panel>();

        private static double panelWidthRectangleParameters = 521;
        private static double panelHeightRectangleParameters = 471;

        public RectanglesParametersUserControl()
        {
            InitializeComponent();
        }

        private void listBoxRectanglesParameters_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxRectanglesParameters.SelectedIndex;

            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
            }
            FindCollisions();

            if (selectedIndex >= 0 && selectedIndex < _rectangles.Count)
            {
                _currentRectangle = _rectangles[selectedIndex];
                UpdateRectangleInfo(_currentRectangle);
                _rectanglePanels[selectedIndex].BackColor = Color.FromArgb(200, 127, 255, 255);
            }
            else
            {
                _currentRectangle = null;
                ClearRectangleInfo();
            }
        }

        private void buttonAddRectangleParameters_Click(object sender, EventArgs e)
        {
            Rectangles _rectangle = Rectangles.RandomRectangle(30, 100, 30, 100, 15, panelWidthRectangleParameters, 15, panelHeightRectangleParameters);
            _rectangles.Add(_rectangle);
            string _rectangle_str = _rectangle.Id.ToString() + ": (" +
                "X= " + _rectangle.Center.X.ToString("F2") + "; Y= " + _rectangle.Center.Y.ToString("F2") +
                "; W= " + _rectangle.Width.ToString("F2") + "; H=" + _rectangle.Length.ToString("F2") + ")";
            listBoxRectanglesParameters.Items.Add(_rectangle_str);

            Panel panel = new Panel();
            int canvasHeight = panelRectanglesDisplay.Height;
            int left = (int)(_rectangle.Center.X - _rectangle.Width / 2);
            int top = (int)(canvasHeight - (_rectangle.Center.Y + _rectangle.Length / 2));
            panel.Location = new Point(left, top);
            panel.Size = new Size((int)_rectangle.Width, (int)_rectangle.Length);
            panel.Size = new Size((int)_rectangle.Width, (int)_rectangle.Length);
            panel.BackColor = Color.FromArgb(127, 127, 255, 127);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panelRectanglesDisplay.Controls.Add(panel);
            _rectanglePanels.Add(panel);
            FindCollisions();
        }

        private void buttonDelRectangleParameters_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxRectanglesParameters.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= _rectangles.Count)
            {
                return;
            }
            panelRectanglesDisplay.Controls.RemoveAt(selectedIndex);
            _rectanglePanels.RemoveAt(selectedIndex);
            _rectangles.RemoveAt(selectedIndex);
            listBoxRectanglesParameters.Items.RemoveAt(selectedIndex);
            FindCollisions();
            // Вариант удаления панели по объекту
            //RectanglesPanel.Controls.Remove(panel);
        }

        private void textBoxXRectangleParameter_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }
            try
            {
                string input = textBoxXRectangleParameter.Text;
                if (!double.TryParse(input, out double value))
                {
                    throw new ArgumentException();
                }
                double minX = _currentRectangle.Width / 2 + 15;
                double maxX = panelWidthRectangleParameters - _currentRectangle.Width / 2 - 15;
                if (value < minX)
                {
                    value = minX;
                }
                else if (value > maxX)
                {
                    value = maxX;
                }
                _currentRectangle.Center.SetX(value);
                UpdateRectangleInListBox();
                UpdatePanel();

            }
            catch
            {
                textBoxXRectangleParameter.Text = _currentRectangle.Center.X.ToString("F2");
            }
            _rectanglePanels[listBoxRectanglesParameters.SelectedIndex].BackColor = Color.FromArgb(200, 127, 255, 255);
        }

        private void textBoxYRectangleParameter_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }
            try
            {
                string input = textBoxYRectangleParameter.Text;
                if (!double.TryParse(input, out double value))
                {
                    throw new ArgumentException();
                }
                double minY = _currentRectangle.Length / 2 + 15;
                double maxY = panelHeightRectangleParameters - _currentRectangle.Length / 2 - 15;
                if (value < minY)
                {
                    value = minY;
                }
                else if (value > maxY)
                {
                    value = maxY;
                }
                _currentRectangle.Center.SetY(value);
                UpdateRectangleInListBox();
                UpdatePanel();
            }
            catch
            {
                textBoxYRectangleParameter.Text = _currentRectangle.Center.Y.ToString("F2");
            }
            _rectanglePanels[listBoxRectanglesParameters.SelectedIndex].BackColor = Color.FromArgb(200, 127, 255, 255);
        }

        private void textBoxWidthRectangleParameter_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }
            try
            {
                string input = textBoxWidthRectangleParameter.Text;
                if (!double.TryParse(input, out double value))
                {
                    throw new ArgumentException();
                }

                //if (value < 0)
                //{
                //    value = 1;
                //}
                //else if (value > 100)
                //{
                //    value = 100;
                //}

                Validator.AssertValueInRange(value, 0, 400, "Width");

                _currentRectangle.Width = value;
                UpdateRectangleInListBox();
                UpdatePanel();
            }
            catch
            {
                textBoxWidthRectangleParameter.Text = _currentRectangle.Width.ToString("F2");
            }
            _rectanglePanels[listBoxRectanglesParameters.SelectedIndex].BackColor = Color.FromArgb(200, 127, 255, 255);
        }

        private void textBoxHeightRectangleParameter_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }
            try
            {
                string input = textBoxHeightRectangleParameter.Text;
                if (!double.TryParse(input, out double value))
                {
                    throw new ArgumentException();
                }

                /*if (value < 0)
                {
                    value = 1;
                }
                else if (value > 100)
                {
                    value = 100;
                }*/

                Validator.AssertValueInRange(value, 0, 400, "Height");

                _currentRectangle.Length = value;
                UpdateRectangleInListBox();
                UpdatePanel();
            }
            catch
            {
                textBoxHeightRectangleParameter.Text = _currentRectangle.Length.ToString("F2");
            }
            _rectanglePanels[listBoxRectanglesParameters.SelectedIndex].BackColor = Color.FromArgb(200, 127, 255, 255);
        }

        private void ClearRectangleInfo()
        {
            textBoxIdRectangleParameter.Text = "";
            textBoxXRectangleParameter.Text = "";
            textBoxYRectangleParameter.Text = "";
            textBoxWidthRectangleParameter.Text = "";
            textBoxHeightRectangleParameter.Text = "";
        }
        private void UpdateRectangleInfo(Rectangles rectangle)
        {
            if (rectangle == null) return;

            textBoxIdRectangleParameter.Text = _currentRectangle.Id.ToString();
            textBoxXRectangleParameter.Text = _currentRectangle.Center.X.ToString("F2");
            textBoxYRectangleParameter.Text = _currentRectangle.Center.Y.ToString("F2");
            textBoxWidthRectangleParameter.Text = _currentRectangle.Width.ToString("F2");
            textBoxHeightRectangleParameter.Text = _currentRectangle.Length.ToString("F2");
        }
        private void UpdatePanel()
        {
            int index = _rectangles.IndexOf(_currentRectangle);
            int canvasHeight = panelRectanglesDisplay.Height;
            int left = (int)(_currentRectangle.Center.X - _currentRectangle.Width / 2);
            int top = (int)(canvasHeight - (_currentRectangle.Center.Y + _currentRectangle.Length / 2));
            _rectanglePanels[index].Location = new Point(left, top);
            _rectanglePanels[index].Size = new Size((int)_currentRectangle.Width, (int)_currentRectangle.Length);
            FindCollisions();
            _rectanglePanels[listBoxRectanglesParameters.SelectedIndex].BackColor = Color.FromArgb(200, 127, 255, 255);
        }
        private void UpdateRectangleInListBox()
        {
            if (_currentRectangle == null) return;

            int selectedIndex = listBoxRectanglesParameters.SelectedIndex;
            string _rectangle_str = _currentRectangle.Id.ToString() + ": (" +
                                "X= " + _currentRectangle.Center.X.ToString("F2") +
                                "; Y= " + _currentRectangle.Center.Y.ToString("F2") +
                                "; W= " + _currentRectangle.Width.ToString("F2") +
                                "; H= " + _currentRectangle.Length.ToString("F2") + ")";
            listBoxRectanglesParameters.Items[selectedIndex] = _rectangle_str;
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
            }
            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    if (i == j) continue;

                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }
    }
}
