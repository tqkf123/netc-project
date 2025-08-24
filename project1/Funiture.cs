using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Funiture : Form
    {

        private List<Furniture> placedFurniture = new List<Furniture>();
        private Furniture selectedFurniture = null;
        private bool isDragging = false;
        private Point dragOffset;


        public Funiture()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            roomPanel.BackColor = Color.White;

            furnitureCatalog.Items.Add("책상");
            furnitureCatalog.Items.Add("의자");
            furnitureCatalog.Items.Add("침대");
            furnitureCatalog.Items.Add("가전제품");
            furnitureCatalog.Items.Add("러그");
            furnitureCatalog.Items.Add("조명");
            furnitureCatalog.Items.Add("트리");


            roomPanel.Paint += roomPanel_Paint;
            roomPanel.MouseDown += roomPanel_MouseDown;
            roomPanel.MouseMove += roomPanel_MouseMove;
            roomPanel.MouseUp += roomPanel_MouseUp;

            rotateLeftButton.Click += rotateLeftButton_Click;
            rotateRightButton.Click += rotateRightButton_Click;
            changeBgButton.Click += changeBgButton_Click;
        }

        private void roomPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            foreach (var furniture in placedFurniture)
            {
                var state = g.Save();
                g.TranslateTransform(furniture.Location.X + furniture.Size.Width / 2,
                                     furniture.Location.Y + furniture.Size.Height / 2);
                g.RotateTransform(furniture.RotationAngle);
                g.TranslateTransform(-(furniture.Location.X + furniture.Size.Width / 2),
                                     -(furniture.Location.Y + furniture.Size.Height / 2));


                if (furniture.FurnitureImage != null)
                {
                    g.DrawImage(furniture.FurnitureImage, new Rectangle(furniture.Location, furniture.Size));
                }
                else
                {
                    using (SolidBrush errorBrush = new SolidBrush(Color.LightGray))
                    {
                        g.FillRectangle(errorBrush, new Rectangle(furniture.Location, furniture.Size));
                    }

                    TextRenderer.DrawText(g, "이미지 없음", this.Font, new Rectangle(furniture.Location, furniture.Size), Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }

                g.Restore(state);


                if (furniture == selectedFurniture)
                {
                    using (Pen selectionPen = new Pen(Color.Red, 2))
                    {
                        selectionPen.DashStyle = DashStyle.Dash;
                        var selectionState = g.Save();
                        g.TranslateTransform(furniture.Location.X + furniture.Size.Width / 2,
                                             furniture.Location.Y + furniture.Size.Height / 2);
                        g.RotateTransform(furniture.RotationAngle);
                        g.TranslateTransform(-(furniture.Location.X + furniture.Size.Width / 2),
                                             -(furniture.Location.Y + furniture.Size.Height / 2));
                        g.DrawRectangle(selectionPen, new Rectangle(furniture.Location, furniture.Size));
                        g.Restore(selectionState);
                    }
                }
            }
        }

        private void roomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (furnitureCatalog.SelectedItem != null)
            {
                CreateNewFurniture(e.Location);
                furnitureCatalog.ClearSelected();
            }
            else
            {
                selectedFurniture = null;

                for (int i = placedFurniture.Count - 1; i >= 0; i--)
                {
                    if (placedFurniture[i].Contains(e.Location))
                    {
                        selectedFurniture = placedFurniture[i];
                        isDragging = true;
                        dragOffset = new Point(e.Location.X - selectedFurniture.Location.X,
                                               e.Location.Y - selectedFurniture.Location.Y);


                        placedFurniture.RemoveAt(i);
                        placedFurniture.Add(selectedFurniture);
                        break;
                    }
                }
            }
            propertyGrid.SelectedObject = selectedFurniture;
            roomPanel.Invalidate();
        }

        private void roomPanel_MouseMove(object sender, MouseEventArgs e)
        {

            if (isDragging && selectedFurniture != null)
            {
                selectedFurniture.Location = new Point(e.Location.X - dragOffset.X, e.Location.Y - dragOffset.Y);
                roomPanel.Invalidate();
                propertyGrid.Refresh();
            }
        }

        private void roomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void rotateLeftButton_Click(object sender, EventArgs e)
        {
            if (selectedFurniture != null)
            {
                selectedFurniture.RotationAngle -= 15;
                roomPanel.Invalidate();
                propertyGrid.Refresh();
            }
        }

        private void rotateRightButton_Click(object sender, EventArgs e)
        {
            if (selectedFurniture != null)
            {
                selectedFurniture.RotationAngle += 15;
                roomPanel.Invalidate();
                propertyGrid.Refresh();
            }
        }

        private void changeBgButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "배경 이미지 선택";
                openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = @"C:\가구 누끼\평면도";
                

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        roomPanel.BackgroundImage = Image.FromFile(openFileDialog.FileName);
                        roomPanel.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"이미지 로드 오류: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void CreateNewFurniture(Point location)
        {
            Furniture newFurniture = null;
            string selectedItem = furnitureCatalog.SelectedItem.ToString();


            switch (selectedItem)
            {
                case "책상":
                    newFurniture = new Furniture("책상", new Size(120, 60), @"C:\가구 누끼\시뮬\1.png");
                    break;
                case "의자":
                    newFurniture = new Furniture("의자", new Size(40, 40), @"C:\가구 누끼\시뮬\7.png");
                    break;
                case "침대":
                    newFurniture = new Furniture("침대", new Size(100, 200), @"C:\가구 누끼\시뮬\2.png");
                    break;
                case "가전제품":
                    newFurniture = new Furniture("가전제품", new Size(100, 60), @"C:\가구 누끼\시뮬\4.png");
                    break;
                case "러그":
                    newFurniture = new Furniture("러그", new Size(150, 250), @"C:\가구 누끼\시뮬\3.png");
                    break;
                case "조명":
                    newFurniture = new Furniture("조명", new Size(30, 30), @"C:\가구 누끼\시뮬\6.png");
                    break;
                case "트리":
                    newFurniture = new Furniture("트리", new Size(60, 60), @"C:\가구 누끼\시뮬\5.png");
                    break;
            }

            if (newFurniture != null)
            {

                if (newFurniture.FurnitureImage != null)
                {
                    newFurniture.Location = new Point(location.X - newFurniture.Size.Width / 2,
                                                      location.Y - newFurniture.Size.Height / 2);
                    placedFurniture.Add(newFurniture);
                    selectedFurniture = newFurniture;
                }
                else
                {
                    newFurniture.Dispose();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (selectedFurniture != null)
            {

                var confirmResult = MessageBox.Show("선택한 가구를 삭제하시겠습니까?",
                                                     "삭제 확인",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // 리스트에서 선택된 가구 제거
                    placedFurniture.Remove(selectedFurniture);

                    // ✨ 3. 가구가 사용하던 이미지 리소스를 메모리에서 해제
                    selectedFurniture.Dispose();

                    // 선택 상태 초기화
                    selectedFurniture = null;
                    propertyGrid.SelectedObject = null;

                    // 화면을 다시 그려서 변경사항 반영
                    roomPanel.Invalidate();
                }
            }
            else
            {
                MessageBox.Show("삭제할 가구를 먼저 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Search chairForm = new Search();
            chairForm.ShowDialog();
            this.Close();
        }
    }



    public class Furniture : IDisposable
    {
        public string Name { get; set; }
        public Point Location { get; set; }
        public Size Size { get; set; }
        public float RotationAngle { get; set; }

        [Browsable(false)]
        public Image FurnitureImage { get; private set; }

        public string ImagePath { get; private set; }

        private bool disposed = false; 

        
        public Furniture(string name, Size size, string imagePath)
        {
            Name = name;
            Size = size;
            ImagePath = imagePath;
            RotationAngle = 0f;
            Location = Point.Empty;

           
            try
            {
                if (File.Exists(imagePath))
                {
                    FurnitureImage = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show($"이미지 파일을 찾을 수 없습니다.\n경로: {imagePath}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FurnitureImage = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"이미지를 불러오는 중 오류가 발생했습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FurnitureImage = null;
            }
        }

        
        public bool Contains(Point point)
        {
            using (Matrix transformMatrix = new Matrix())
            {
                Point center = new Point(Location.X + Size.Width / 2, Location.Y + Size.Height / 2);

                transformMatrix.Translate(-center.X, -center.Y, MatrixOrder.Append);
                transformMatrix.Rotate(-this.RotationAngle, MatrixOrder.Append);
                transformMatrix.Translate(center.X, center.Y, MatrixOrder.Append);

                Point[] points = { point };
                transformMatrix.TransformPoints(points);
                Point transformedPoint = points[0];

                return new Rectangle(this.Location, this.Size).Contains(transformedPoint);
            }
        }

        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            if (disposing)
            {
                
                FurnitureImage?.Dispose();
            }

            disposed = true;
        }
    }

}