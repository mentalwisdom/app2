//step6.1 create a new data model to support product
//step6.3 import the following lib->namespace below
using System;
using System.ComponentModel.DataAnnotations;

namespace app2.Models{
    public class Product {
        //step 6.2: put key to denote the primary for the target field
        [Key]
        public int productId {get;set;}
        [StringLength(5)]
        public string productName {get;set;}
        //[MinLength(5)]
        [RegularExpression(@"\d{3}-\d{3}", ErrorMessage = "please enter format xxx-xxx")]
        public string productCode {get;set;}
        // xxx-xxx
        public DateTime createdDate {get;set;}
        //to use DateTime you need to import System lib
        //step7: go ahead and then issue two command
        //to make database migration and database update
        //dotnet ef migrations add "one" -v
        //dotnet ef database update
        //if you see Build failed message
        //then to validate the error , we call "dotnet build"

        //step8: let auto gen view and controller for Product Model
        //dotnet aspnet-codegenerator controller -name ProductController -actions -m Product -dc MISDbContext -outDir Controllers

    }//ec
}//en
