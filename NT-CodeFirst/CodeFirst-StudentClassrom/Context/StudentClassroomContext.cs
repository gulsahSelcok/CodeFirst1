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
        //Context s�n�f�nda verilen herbir properties belirtilmelid�R.Aksi halde veritaban�m�zda tablo olu�maz.Bu alana hangi entitylerimizi veritaban�nda tablo olarak g�rmek istiyorsak o classlar� ekliyoruz.

        public virtual DbSet<Student> Students { get; set; } //Burada tan�mlad���m�z entitylerimizin facadelar� tan�mlan�r.
        public virtual DbSet<Classroom> Classrooms { get; set; } //Veritaban�nda alanlar�n sonunda s bulunur. Kod k�sm�nda bulunmaz.Veri taban�nda pluralize edilir.
    }
    
}