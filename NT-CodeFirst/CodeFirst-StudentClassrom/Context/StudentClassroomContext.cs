namespace CodeFirst_StudentClassrom
{
    using CodeFirst_StudentClassrom.Context;
    using System;
    using System.Data.Entity;
    using System.Linq;
    //Author(GulsahSELCOK)

    public class StudentClassroomContext : DbContext
    {
        // Your context has been configured to use a 'StudentClassroomContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirst_StudentClassrom.StudentClassroomContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StudentClassroomContext' 
        // connection string in the application configuration file.
        public StudentClassroomContext()
            : base("name=StudentClassroomContext")
        {
        }
        //Context sınıfında verilen herbir properties belirtilmelidİR.Aksi halde veritabanımızda tablo oluşmaz.Bu alana hangi entitylerimizi veritabanında tablo olarak görmek istiyorsak o classları ekliyoruz.

        public virtual DbSet<Student> Students { get; set; } //Burada tanımladığımız entitylerimizin facadeları tanımlanır.
        public virtual DbSet<Classroom> Classrooms { get; set; } //Veritabanında alanların sonunda s bulunur. Kod kısmında bulunmaz.Veri tabanında pluralize edilir.
    }
    
}