namespace Model
{
    public class Dosen
    {
        private String NIP { get; set; }
        private String email { get; set; }
        private String first_name { get; set; }
        private String last_name { get; set; }
        private String kode_dosen { get; set; }
        private String gender { get; set; }
        private String prodi { get; set; }
        private String fakultas { get; set; }
        private int phone { get; set; }
        private List<Tim_Proyek> listTimProyek { get; set; }
        private List<Proyek> listProyek { get; set; }
        private String status { get; set; }
        private String password { get; set; }

        public Dosen(String email, String first_name, String last_name, String gender, string password)
        {
            this.email = email;
            this.first_name = first_name;
            this.last_name = last_name;
            this.gender = gender;
            this.password = password;

        }
    }
}
