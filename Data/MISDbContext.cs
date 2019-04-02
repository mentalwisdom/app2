//step5.1 import the following lib

using app2.Models;//don't forget to put app2.Models to support
//you data model here
using Microsoft.EntityFrameworkCore;

namespace app2.Data{

//step5.2: create a new class that extends from DbContext
 public class MISDbContext:DbContext{

        //step5.3: create a constructdor for this  class
        public MISDbContext(DbContextOptions<MISDbContext> option) : base(option)
        {
        }

        //table connection 
        //create a meta data to support physical table 
        //step6: go ahead and create the Product Model file
        public DbSet<Product> products {get;set;}

 }//ec

}//en