﻿using GUI.DAO;
using GUI.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAdmin : Form
    {
        BindingSource staffList = new BindingSource();
		BindingSource customerList = new BindingSource();
		BindingSource genreList = new BindingSource();
		BindingSource screenTypeList = new BindingSource();
		BindingSource cinemaList = new BindingSource();
		BindingSource movieList = new BindingSource();
		BindingSource formatList = new BindingSource();

		public frmAdmin()
        {
            InitializeComponent();

			LoadRevenue();
			
			LoadStaff();

			LoadCustomer();

			LoadGenre();

			LoadScreenType();

			LoadCinema();

			LoadMovie();

			LoadFormatMovie();
		}

		#region Doanh Thu
		void LoadRevenue()
		{
			LoadMovieIntoCombobox(cboSelectMovie);
			LoadDateTimePickerRevenue();//Set "Từ ngày" & "Đến ngày ngày" về đầu tháng & cuối tháng
			LoadRevenue(cboSelectMovie.SelectedValue.ToString(), dtmFromDate.Value, dtmToDate.Value);
		}

		void LoadMovieIntoCombobox(ComboBox comboBox)
		{
			comboBox.DataSource = MovieDAO.GetListMovie();
			comboBox.DisplayMember = "Name";
			comboBox.ValueMember = "ID";
		}

		void LoadDateTimePickerRevenue()
		{
			dtmFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			dtmToDate.Value = dtmFromDate.Value.AddMonths(1).AddDays(-1);
		}

		decimal GetSumRevenue()
		{
			decimal sum = 0;
			foreach (DataGridViewRow row in dtgvRevenue.Rows)
			{
				sum += Convert.ToDecimal(row.Cells["Tiền vé"].Value);
			}
			return sum;
		}

		void LoadRevenue(string idMovie, DateTime fromDate, DateTime toDate)
		{
			dtgvRevenue.DataSource = RevenueDAO.GetRevenue(idMovie, fromDate, toDate);
			txtDoanhThu.Text = GetSumRevenue().ToString() + " VNĐ";
		}

		private void btnShowRevenue_Click(object sender, EventArgs e)
		{
			LoadRevenue(cboSelectMovie.SelectedValue.ToString(), dtmFromDate.Value, dtmToDate.Value);
		}
		#endregion

		#region Nhân Viên
		void LoadStaff()
		{
			dtgvStaff.DataSource = staffList;
			LoadStaffList();
			AddStaffBinding();
		}

        void LoadStaffList()
        {
            staffList.DataSource = StaffDAO.GetListStaff();
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            LoadStaffList();
        }
        void AddStaffBinding()
        {
            txtStaffId.DataBindings.Add("Text", dtgvStaff.DataSource, "Mã nhân viên", true, DataSourceUpdateMode.Never);
            txtStaffName.DataBindings.Add("Text", dtgvStaff.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            txtStaffBirth.DataBindings.Add("Text", dtgvStaff.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
            txtStaffAddress.DataBindings.Add("Text", dtgvStaff.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never);
            txtStaffPhone.DataBindings.Add("Text", dtgvStaff.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
            txtStaffINumber.DataBindings.Add("Text", dtgvStaff.DataSource, "CMND", true, DataSourceUpdateMode.Never);

        }


		//Thêm Staff
        void AddStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            if (StaffDAO.InsertStaff(id, hoTen, ngaySinh, diaChi, sdt, cmnd))
            {
                MessageBox.Show("Thêm nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text;
            string staffName = txtStaffName.Text;
            DateTime staffBirth = DateTime.Parse(txtStaffBirth.Text);
            string staffAddress = txtStaffAddress.Text;
            string staffPhone = txtStaffPhone.Text;
            int staffINumber = Int32.Parse(txtStaffINumber.Text);
            AddStaff(staffId, staffName, staffBirth, staffAddress, staffPhone, staffINumber);
            LoadStaffList();
        }

		//Sửa Staff
		void UpdateStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
		{
			if (StaffDAO.UpdateStaff(id, hoTen, ngaySinh, diaChi, sdt, cmnd))
			{
				MessageBox.Show("Sửa nhân viên thành công");
			}
			else
			{
				MessageBox.Show("Sửa nhân viên thất bại");
			}
		}
		private void btnUpdateStaff_Click(object sender, EventArgs e)
		{
			string staffId = txtStaffId.Text;
			string staffName = txtStaffName.Text;
			DateTime staffBirth = DateTime.Parse(txtStaffBirth.Text);
			string staffAddress = txtStaffAddress.Text;
			string staffPhone = txtStaffPhone.Text;
			int staffINumber = Int32.Parse(txtStaffINumber.Text);
			UpdateStaff(staffId, staffName, staffBirth, staffAddress, staffPhone, staffINumber);
			LoadStaffList();
		}

		//Xóa Staff
		void DeleteStaff(string id)
		{
			if (StaffDAO.DeleteStaff(id))
			{
				MessageBox.Show("Xóa nhân viên thành công");
			}
			else
			{
				MessageBox.Show("Xóa nhân viên thất bại");
			}
		}
		private void btnDeleteStaff_Click(object sender, EventArgs e)
		{
			string staffId = txtStaffId.Text;
			DeleteStaff(staffId);
			LoadStaffList();
		}

		//Tìm kiếm Staff
		private void btnSearchStaff_Click(object sender, EventArgs e)
		{
			string staffName = txtSearchStaff.Text;
			DataTable staffSearchList = StaffDAO.SearchStaffByName(staffName);
			staffList.DataSource = staffSearchList;
		}

		private void txtSearchStaff_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnSearchStaff.PerformClick();
				e.SuppressKeyPress = true;//Tắt tiếng *ting của windows
			}
		}
		#endregion

		#region Khách Hàng
		void LoadCustomer()
		{
			dtgvCustomer.DataSource = customerList;
			LoadCustomerList();
			AddCustomerBinding();
		}

		void LoadCustomerList()
        {
            customerList.DataSource = CustomerDAO.GetListCustomer();
        }
        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

		void AddCustomerBinding()
		{
			txtCusID.DataBindings.Add("Text", dtgvCustomer.DataSource, "Mã khách hàng", true, DataSourceUpdateMode.Never);
			txtCusName.DataBindings.Add("Text", dtgvCustomer.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
			txtCusBirth.DataBindings.Add("Text", dtgvCustomer.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
			txtCusAddress.DataBindings.Add("Text", dtgvCustomer.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never);
			txtCusPhone.DataBindings.Add("Text", dtgvCustomer.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
			txtCusINumber.DataBindings.Add("Text", dtgvCustomer.DataSource, "CMND", true, DataSourceUpdateMode.Never);
			nudPoint.DataBindings.Add("Value", dtgvCustomer.DataSource, "Điểm tích lũy", true, DataSourceUpdateMode.Never);
		}

		void InsertCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
		{
			if (CustomerDAO.InsertCustomer(id, hoTen, ngaySinh, diaChi, sdt, cmnd))
			{
				MessageBox.Show("Thêm khách hàng thành công");
			}
			else
			{
				MessageBox.Show("Thêm khách hàng thất bại");
			}
		}
		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			string cusID = txtCusID.Text;
			string cusName = txtCusName.Text;
			DateTime cusBirth = DateTime.Parse(txtCusBirth.Text);
			string cusAddress = txtCusAddress.Text;
			string cusPhone = txtCusPhone.Text;
			int cusINumber = Int32.Parse(txtCusINumber.Text);
			InsertCustomer(cusID, cusName, cusBirth, cusAddress, cusPhone, cusINumber);
			LoadCustomerList();
		}

		void UpdateCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd, int point)
		{
			if (CustomerDAO.UpdateCustomer(id, hoTen, ngaySinh, diaChi, sdt, cmnd, point))
			{
				MessageBox.Show("Sửa khách hàng thành công");
			}
			else
			{
				MessageBox.Show("Sửa khách hàng thất bại");
			}
		}
		private void btnUpdateCustomer_Click(object sender, EventArgs e)
		{
			string cusID = txtCusID.Text;
			string cusName = txtCusName.Text;
			DateTime cusBirth = DateTime.Parse(txtCusBirth.Text);
			string cusAddress = txtCusAddress.Text;
			string cusPhone = txtCusPhone.Text;
			int cusINumber = Int32.Parse(txtCusINumber.Text);
			int cusPoint = (int)nudPoint.Value;
			UpdateCustomer(cusID, cusName, cusBirth, cusAddress, cusPhone, cusINumber, cusPoint);
			LoadCustomerList();
		}

		void DeleteCustomer(string id)
		{
			if (CustomerDAO.DeleteCustomer(id))
			{
				MessageBox.Show("Xóa khách hàng thành công");
			}
			else
			{
				MessageBox.Show("Xóa khách hàng thất bại");
			}
		}
		private void btnDeleteCustomer_Click(object sender, EventArgs e)
		{
			string cusID = txtCusID.Text;
			DeleteCustomer(cusID);
			LoadCustomerList();
		}

		private void btnSearchCus_Click(object sender, EventArgs e)
		{
			string cusName = txtSearchCus.Text;
			customerList.DataSource = CustomerDAO.SearchCustomerByName(cusName);
		}
		private void txtSearchCus_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnSearchCus.PerformClick();
				e.SuppressKeyPress = true;
			}
		}
		#endregion

		//Tab 'Dữ liệu'
		#region Thể Loại
		void LoadGenre()
		{
			dtgvGenre.DataSource = genreList;
			LoadGenreList();
			AddGenreBinding();
		}
		void LoadGenreList()
		{
			genreList.DataSource = GenreDAO.GetGenre();
		}
		void AddGenreBinding()
		{
			txtGenreID.DataBindings.Add("Text", dtgvGenre.DataSource, "Mã thể loại", true, DataSourceUpdateMode.Never);
			txtGenreName.DataBindings.Add("Text", dtgvGenre.DataSource, "Tên thể loại", true, DataSourceUpdateMode.Never);
			txtGenreDesc.DataBindings.Add("Text", dtgvGenre.DataSource, "Mô tả", true, DataSourceUpdateMode.Never);
		}
		private void btnShowGenre_Click(object sender, EventArgs e)
		{
			LoadGenreList();
		}

		void InsertGenre(string id, string name, string desc)
		{
			if (GenreDAO.InsertGenre(id, name, desc))
			{
				MessageBox.Show("Thêm thể loại thành công");
			}
			else
			{
				MessageBox.Show("Thêm thể loại thất bại");
			}
		}
		private void btnInsertGenre_Click(object sender, EventArgs e)
		{
			string GenreID = txtGenreID.Text;
			string GenreName = txtGenreName.Text;
			string GenreDesc = txtGenreDesc.Text;
			InsertGenre(GenreID, GenreName, GenreDesc);
			LoadGenreList();
		}

		void UpdateGenre(string id, string name, string desc)
		{
			if (GenreDAO.UpdateGenre(id, name, desc))
			{
				MessageBox.Show("Sửa thể loại thành công");
			}
			else
			{
				MessageBox.Show("Sửa thể loại thất bại");
			}
		}
		private void btnUpdateGenre_Click(object sender, EventArgs e)
		{
			string GenreID = txtGenreID.Text;
			string GenreName = txtGenreName.Text;
			string GenreDesc = txtGenreDesc.Text;
			UpdateGenre(GenreID, GenreName, GenreDesc);
			LoadGenreList();
		}

		void DeleteGenre(string id)
		{
			if (GenreDAO.DeleteGenre(id))
			{
				MessageBox.Show("Xóa thể loại thành công");
			}
			else
			{
				MessageBox.Show("Xóa thể loại thất bại");
			}
		}
		private void btnDeleteGenre_Click(object sender, EventArgs e)
		{
			string GenreID = txtGenreID.Text;
			DeleteGenre(GenreID);
			LoadGenreList();
		}
		#endregion

		#region Loại Màn Hình
		void LoadScreenType()
		{
			dtgvScreenType.DataSource = screenTypeList;
			LoadScreenTypeList();
			AddScreenTypeBinding();
		}
		void LoadScreenTypeList()
		{
			screenTypeList.DataSource = ScreenTypeDAO.GetScreenType();
		}
		void AddScreenTypeBinding()
		{
			txtScreenTypeID.DataBindings.Add("Text", dtgvScreenType.DataSource, "Mã loại màn hình");
			txtScreenTypeName.DataBindings.Add("Text", dtgvScreenType.DataSource, "Tên màn hình");
		}
		private void btnShowScreenType_Click(object sender, EventArgs e)
		{
			LoadScreenTypeList();
		}

		void InsertScreenType(string id, string name)
		{
			if (ScreenTypeDAO.InsertScreenType(id, name))
			{
				MessageBox.Show("Thêm loại màn hình thành công");
			}
			else
			{
				MessageBox.Show("Thêm loại màn hình thất bại");
			}
		}
		private void btnInsertScreenType_Click(object sender, EventArgs e)
		{
			string screenTypeID = txtScreenTypeID.Text;
			string screenTypeName = txtScreenTypeName.Text;
			InsertScreenType(screenTypeID, screenTypeName);
			LoadScreenTypeList();
		}

		void UpdateScreenType(string id, string name)
		{
			if (ScreenTypeDAO.UpdateScreenType(id, name))
			{
				MessageBox.Show("Sửa loại màn hình thành công");
			}
			else
			{
				MessageBox.Show("Sửa loại màn hình thất bại");
			}
		}
		private void btnUpdateScreenType_Click(object sender, EventArgs e)
		{
			string screenTypeID = txtScreenTypeID.Text;
			string screenTypeName = txtScreenTypeName.Text;
			UpdateScreenType(screenTypeID, screenTypeName);
			LoadScreenTypeList();
		}

		void DeleteScreenType(string id)
		{
			if (ScreenTypeDAO.DeleteScreenType(id))
			{
				MessageBox.Show("Xóa loại màn hình thành công");
			}
			else
			{
				MessageBox.Show("Xóa loại màn hình thất bại");
			}
		}
		private void btnDeleteScreenType_Click(object sender, EventArgs e)
		{
			string screenTypeID = txtScreenTypeID.Text;
			DeleteScreenType(screenTypeID);
			LoadScreenTypeList();
		}
		#endregion

		#region Phòng chiếu
		void LoadCinema()
		{
			dtgvCinema.DataSource = cinemaList;
			LoadCinemaList();
			AddCinemaBinding();
		}
		void LoadCinemaList()
		{
			cinemaList.DataSource = CinemaDAO.GetListCinema();
		}
		void AddCinemaBinding()
		{
			txtCinemaID.DataBindings.Add("Text", dtgvCinema.DataSource, "Mã phòng");
			txtCinemaName.DataBindings.Add("Text", dtgvCinema.DataSource, "Tên phòng");
			txtCinemaSeats.DataBindings.Add("Text", dtgvCinema.DataSource, "Số chỗ ngồi");
			txtCinemaStatus.DataBindings.Add("Text", dtgvCinema.DataSource, "Tình trạng");
			txtNumberOfRows.DataBindings.Add("Text", dtgvCinema.DataSource, "Số hàng ghế");
			txtSeatsPerRow.DataBindings.Add("Text", dtgvCinema.DataSource, "Ghế mỗi hàng");
			LoadScreenTypeIntoComboBox(cboCinemaScreenType);
		}
		void LoadScreenTypeIntoComboBox(ComboBox cbo)
		{
			cbo.DataSource = ScreenTypeDAO.GetListScreenType();
			cbo.DisplayMember = "Name";
			cbo.ValueMember = "ID";
		}
		private void txtCinemaID_TextChanged(object sender, EventArgs e)
			//Use this to bind data between dtgv and cbo because cbo can't be applied DataBindings normally
		{
			string screenName = (string)dtgvCinema.SelectedCells[0].OwningRow.Cells["Tên màn hình"].Value;
			ScreenType screenType = ScreenTypeDAO.GetScreenTypeByName(screenName);
			//This is the ScreenType that we're currently selecting in dtgv

			cboCinemaScreenType.SelectedItem = screenType;

			int index = -1;
			int i = 0;
			foreach (ScreenType item in cboCinemaScreenType.Items)
			{
				if (item.Name == screenType.Name)
				{
					index = i;
					break;
				}
				i++;
			}
			cboCinemaScreenType.SelectedIndex = index;
		}

		private void btnShowCinema_Click(object sender, EventArgs e)
		{
			LoadCinemaList();
		}

		void InsertCinema(string id, string name, string idMH, int seats, int status, int numberOfRows, int seatsPerRow)
		{
			if (CinemaDAO.InsertCinema(id, name,idMH,seats,status,numberOfRows,seatsPerRow))
			{
				MessageBox.Show("Thêm phòng chiếu thành công");
			}
			else
			{
				MessageBox.Show("Thêm phòng chiếu thất bại");
			}
		}
		private void btnInsertCinema_Click(object sender, EventArgs e)
		{
			string cinemaID = txtCinemaID.Text;
			string cinemaName = txtCinemaName.Text;
			string screenTypeID = cboCinemaScreenType.SelectedValue.ToString();
			int cinemaSeats = int.Parse(txtCinemaSeats.Text);
			int cinemaStatus = int.Parse(txtCinemaStatus.Text);
			int numberOfRows = int.Parse(txtNumberOfRows.Text);
			int seatsPerRows = int.Parse(txtSeatsPerRow.Text);
			InsertCinema(cinemaID, cinemaName, screenTypeID, cinemaSeats, cinemaStatus, numberOfRows, seatsPerRows);
			LoadCinemaList();
		}

		void UpdateCinema(string id, string name, string idMH, int seats, int status, int numberOfRows, int seatsPerRow)
		{
			if (CinemaDAO.UpdateCinema(id, name, idMH, seats, status, numberOfRows, seatsPerRow))
			{
				MessageBox.Show("Sửa phòng chiếu thành công");
			}
			else
			{
				MessageBox.Show("Sửa phòng chiếu thất bại");
			}
		}
		private void btnUpdateCinema_Click(object sender, EventArgs e)
		{
			string cinemaID = txtCinemaID.Text;
			string cinemaName = txtCinemaName.Text;
			string screenTypeID = cboCinemaScreenType.SelectedValue.ToString();
			int cinemaSeats = int.Parse(txtCinemaSeats.Text);
			int cinemaStatus = int.Parse(txtCinemaStatus.Text);
			int numberOfRows = int.Parse(txtNumberOfRows.Text);
			int seatsPerRows = int.Parse(txtSeatsPerRow.Text);
			UpdateCinema(cinemaID, cinemaName, screenTypeID, cinemaSeats, cinemaStatus, numberOfRows, seatsPerRows);
			LoadCinemaList();
		}

		void DeleteCinema(string id)
		{
			if (CinemaDAO.DeleteCinema(id))
			{
				MessageBox.Show("Xóa phòng chiếu thành công");
			}
			else
			{
				MessageBox.Show("Xóa phòng chiếu thất bại");
			}
		}
		private void btnDeleteCinema_Click(object sender, EventArgs e)
		{
			string cinemaID = txtCinemaID.Text;
			DeleteCinema(cinemaID);
			LoadCinemaList();
		}
		#endregion

		#region Phim
		void LoadMovie()
		{
			dtgvMovie.DataSource = movieList;
			LoadMovieList();
			AddMovieBinding();
		}
		void LoadMovieList()
		{
			movieList.DataSource = MovieDAO.GetMovie();
		}
		private void btnShowMovie_Click(object sender, EventArgs e)
		{
			LoadMovieList();
		}
		void AddMovieBinding()
		{
			txtMovieID.DataBindings.Add("Text", dtgvMovie.DataSource, "Mã phim");
			txtMovieName.DataBindings.Add("Text", dtgvMovie.DataSource, "Tên phim");
			txtMovieDesc.DataBindings.Add("Text", dtgvMovie.DataSource, "Mô tả");
			txtMovieLength.DataBindings.Add("Text", dtgvMovie.DataSource, "Thời lượng");
			dtmMovieStart.DataBindings.Add("Value", dtgvMovie.DataSource, "Ngày khởi chiếu");
			dtmMovieEnd.DataBindings.Add("Value", dtgvMovie.DataSource, "Ngày kết thúc");
			txtMovieProductor.DataBindings.Add("Text", dtgvMovie.DataSource, "Sản xuất");
			txtMovieDirector.DataBindings.Add("Text", dtgvMovie.DataSource, "Đạo diễn");
			txtMovieYear.DataBindings.Add("Text", dtgvMovie.DataSource, "Năm SX");
			LoadGenreIntoCheckedList(clbMovieGenre);
		}
		void LoadGenreIntoCheckedList(CheckedListBox checkedList)
		{
			List<Genre> genreList = GenreDAO.GetListGenre();
			checkedList.DataSource = genreList;
			checkedList.DisplayMember = "Name";
		}
		private void txtMovieID_TextChanged(object sender, EventArgs e)
			//Use to binding the CheckedListBox Genre of Movie
		{
			for (int i = 0; i < clbMovieGenre.Items.Count; i++)
			{
				clbMovieGenre.SetItemChecked(i, false);
				//Uncheck all CheckBox first
			}

			List<Genre> listGenreOfMovie = MovieByGenreDAO.GetListGenreByMovieID(txtMovieID.Text);
			for (int i = 0; i < clbMovieGenre.Items.Count; i++)
			{
				Genre genre = (Genre)clbMovieGenre.Items[i];
				foreach (Genre item in listGenreOfMovie)
				{
					if (genre.ID == item.ID)
					{
						clbMovieGenre.SetItemChecked(i, true);
						break;
					}
				}
			}
		}

		void InsertMovie(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string productor, string director, int year)
		{
			if (MovieDAO.InsertMovie(id, name, desc, length, startDate, endDate, productor, director, year))
			{
				MessageBox.Show("Thêm phim thành công");
			}
			else
			{
				MessageBox.Show("Thêm phim thất bại");
			}
		}
		void InsertMovie_Genre(string movieID, CheckedListBox checkedListBox)
			//Insert into table 'PhanLoaiPhim'
		{
			List<Genre> checkedGenreList = new List<Genre>();
			foreach (Genre checkedItem in checkedListBox.CheckedItems)
			{
				checkedGenreList.Add(checkedItem);
			}
			MovieByGenreDAO.InsertMovie_Genre(movieID, checkedGenreList);
		}
		private void btnAddMovie_Click(object sender, EventArgs e)
		{
			string movieID = txtMovieID.Text;
			string movieName = txtMovieName.Text;
			string movieDesc = txtMovieDesc.Text;
			float movieLength = float.Parse(txtMovieLength.Text);
			DateTime startDate = dtmMovieStart.Value;
			DateTime endDate = dtmMovieEnd.Value;
			string productor = txtMovieProductor.Text;
			string director = txtMovieDirector.Text;
			int year = int.Parse(txtMovieYear.Text);
			InsertMovie(movieID, movieName, movieDesc, movieLength, startDate, endDate, productor, director, year);
			InsertMovie_Genre(movieID, clbMovieGenre);
			LoadMovieList();
		}

		void UpdateMovie(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string productor, string director, int year)
		{
			if (MovieDAO.UpdateMovie(id, name, desc, length, startDate, endDate, productor, director, year))
			{
				MessageBox.Show("Sửa phim thành công");
			}
			else
			{
				MessageBox.Show("Sửa phim thất bại");
			}
		}
		void UpdateMovie_Genre(string movieID, CheckedListBox checkedListBox)
		{
			List<Genre> checkedGenreList = new List<Genre>();
			foreach (Genre checkedItem in checkedListBox.CheckedItems)
			{
				checkedGenreList.Add(checkedItem);
			}
			MovieByGenreDAO.UpdateMovie_Genre(movieID, checkedGenreList);
		}
		private void btnUpdateMovie_Click(object sender, EventArgs e)
		{
			string movieID = txtMovieID.Text;
			string movieName = txtMovieName.Text;
			string movieDesc = txtMovieDesc.Text;
			float movieLength = float.Parse(txtMovieLength.Text);
			DateTime startDate = dtmMovieStart.Value;
			DateTime endDate = dtmMovieEnd.Value;
			string productor = txtMovieProductor.Text;
			string director = txtMovieDirector.Text;
			int year = int.Parse(txtMovieYear.Text);
			UpdateMovie(movieID, movieName, movieDesc, movieLength, startDate, endDate, productor, director, year);
			UpdateMovie_Genre(movieID, clbMovieGenre);
			LoadMovieList();
		}

		void DeleteMovie(string id)
		{
			if (MovieDAO.DeleteMovie(id))
			{
				MessageBox.Show("Xóa phim thành công");
			}
			else
			{
				MessageBox.Show("Xóa phim thất bại");
			}
		}
		private void btnDeleteMovie_Click(object sender, EventArgs e)
		{
			string movieID = txtMovieID.Text;
			DeleteMovie(movieID);
			LoadMovieList();
		}
		#endregion

		#region Định Dạng
		void LoadFormatMovie()
		{
			dtgvFormat.DataSource = formatList;
			LoadFormatMovieList();
			LoadMovieIDIntoCombobox(cboFormat_MovieID);
			LoadScreenIDIntoCombobox(cboFormat_ScreenID);
			AddFormatBinding();
			
		}
		void LoadMovieIDIntoCombobox(ComboBox comboBox)
		{
			comboBox.DataSource = MovieDAO.GetListMovie();
			comboBox.DisplayMember = "ID";
			comboBox.ValueMember = "ID";
		}
		private void cboFormat_MovieID_SelectedValueChanged(object sender, EventArgs e)
			//Display the MovieName when MovieID changed
		{
			Movie movieSelected = cboFormat_MovieID.SelectedItem as Movie;
			txtFormat_MovieName.Text = movieSelected.Name;
		}
		void LoadScreenIDIntoCombobox(ComboBox comboBox)
		{
			comboBox.DataSource = ScreenTypeDAO.GetListScreenType();
			comboBox.DisplayMember = "ID";
			comboBox.ValueMember = "ID";
		}
		private void cboFormat_ScreenID_SelectedValueChanged(object sender, EventArgs e)
		{
			ScreenType screenTypeSelected = cboFormat_ScreenID.SelectedItem as ScreenType;
			txtFormat_ScreenName.Text = screenTypeSelected.Name;
		}
		void LoadFormatMovieList()
		{
			formatList.DataSource = FormatMovieDAO.GetFormatMovie();
		}

		void AddFormatBinding()
		{
			txtFormatID.DataBindings.Add("Text", dtgvFormat.DataSource, "Mã định dạng", true, DataSourceUpdateMode.Never);
		}
		private void txtFormatID_TextChanged(object sender, EventArgs e)
		{
			string movieID = (string)dtgvFormat.SelectedCells[0].OwningRow.Cells["Mã phim"].Value;
			Movie movieSelecting = MovieDAO.GetMovieByID(movieID);
			//This is the Movie that we're currently selecting in dtgv

			if (movieSelecting == null)
				return;

			//cboFormat_MovieID.SelectedItem = movieSelecting;

			int indexMovie = -1;
			int iMovie = 0;
			foreach (Movie item in cboFormat_MovieID.Items)
			{
				if (item.Name == movieSelecting.Name)
				{
					indexMovie = iMovie;
					break;
				}
				iMovie++;
			}
			cboFormat_MovieID.SelectedIndex = indexMovie;


			string screenName = (string)dtgvFormat.SelectedCells[0].OwningRow.Cells["Tên MH"].Value;
			ScreenType screenTypeSelecting = ScreenTypeDAO.GetScreenTypeByName(screenName);
			//This is the ScreenType that we're currently selecting in dtgv

			if (screenTypeSelecting == null)
				return;

			//cboFormat_ScreenID.SelectedItem = screenTypeSelecting;

			int indexScreen = -1;
			int iScreen = 0;
			foreach (ScreenType item in cboFormat_ScreenID.Items)
			{
				if (item.Name == screenTypeSelecting.Name)
				{
					indexScreen = iScreen;
					break;
				}
				iScreen++;
			}
			cboFormat_ScreenID.SelectedIndex = indexScreen;
		}

		private void btnShowFormat_Click(object sender, EventArgs e)
		{
			LoadFormatMovieList();
		}

		void InsertFormat(string id, string idMovie, string idScreen)
		{
			if (FormatMovieDAO.InsertFormatMovie(id, idMovie, idScreen))
			{
				MessageBox.Show("Thêm định dạng thành công");
			}
			else
			{
				MessageBox.Show("Thêm định dạng thất bại");
			}
		}
		private void btnInsertFormat_Click(object sender, EventArgs e)
		{
			string formatID = txtFormatID.Text;
			string movieID = cboFormat_MovieID.SelectedValue.ToString();
			string screenID = cboFormat_ScreenID.SelectedValue.ToString();
			InsertFormat(formatID, movieID, screenID);
			LoadFormatMovieList();
		}

		void UpdateFormat(string id, string idMovie, string idScreen)
		{
			if (FormatMovieDAO.UpdateFormatMovie(id, idMovie, idScreen))
			{
				MessageBox.Show("Sửa định dạng thành công");
			}
			else
			{
				MessageBox.Show("Sửa định dạng thất bại");
			}
		}
		private void btnUpdateFormat_Click(object sender, EventArgs e)
		{
			string formatID = txtFormatID.Text;
			string movieID = cboFormat_MovieID.SelectedValue.ToString();
			string screenID = cboFormat_ScreenID.SelectedValue.ToString();
			UpdateFormat(formatID, movieID, screenID);
			LoadFormatMovieList();
		}

		void DeleteFormat(string id)
		{
			if (FormatMovieDAO.DeleteFormatMovie(id))
			{
				MessageBox.Show("Xóa định dạng thành công");
			}
			else
			{
				MessageBox.Show("Xóa định dạng thất bại");
			}
		}
		private void btnDeleteFormat_Click(object sender, EventArgs e)
		{
			string formatID = txtFormatID.Text;
			DeleteFormat(formatID);
			LoadFormatMovieList();
		}
		#endregion

	}
}