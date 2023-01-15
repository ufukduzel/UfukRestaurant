using Microsoft.EntityFrameworkCore;
using Ufuk.Services.ProductAPI.Models.Dto;

namespace Ufuk.Services.ProductAPI.DbContexts
{
    //3rd step.
    public class ApplicationDbContext : DbContext
    {
        //4th step.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //8th step.
        public DbSet<Product> Products { get; set; }

        //9th step.
        //Package Manager Console (Default project: Services\Ufuk.Services.ProductAPI)
        //add-migration AddProductModelToDb
        //update-database

        //37th step.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //38th step.
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samosa",
                Price = 15,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "url",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Paneer Tikka",
                Price = 13.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "url",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sweet Pie",
                Price = 10.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "url",
                CategoryName = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Pav Bhaji",
                Price = 15,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "url",
                CategoryName = "Entree"
            });

            //39th step.
            //Go to portal.azure.com
            //If you do not have an account, sign up for a free account.
            //The first service that we will look into is 'Storage Accounts'.
            //We will 'create' a new storage account.
            //This is a new subscription, I do not have a 'resource group'.
            //So I will create a 'resource group' with the name of 'UdemyMicroservice'.
            //Then we need to give a 'storage account name', 'dotnetmastery'
            //We will go to the 'advanced' action.
            //->   Next: Networking   ->   Next: Data protection
            //->   Next: Tags   ->   Next: Review + create
            //And once the validation passes, we will create this.
            //Once the deployment is successful, we can 'go to resource'.
            //You can see the a 'storage explorer' in the 'preview' version.
            //You can also download the storage explorer.
            //So we will search 'azure storage explorer download'.
            //'azure.microsoft.com/en-us/features/storage-explorer
            //You can download 'Azure Storage Explorer' and install.
            //Once you install and open up, it will ask you to connect something. 
            //We will connect to azure 'subscription'.
            //Azure   ->   Next
            //We had authenticated, we can close those and we are signed in.
            //We will attach the 'default directory' in there,
            //We have the 'Azure subscription 1'
            //We will select 'Open Explorer'
            //We have 'Azure subscription 1' right here.
            //->   Azure subscription 1   ->   Storage Accounts
            //->   'dotnetmastery'   ->   Blob Containers
            //Then inside the 'blob containers'.
            //We can 'create' a new 'blob container' with the name of 'ufuk'.
            //We want to upload all of the images. We will upload our images.
            //Upload   ->   Upload Files...
            //Selected Files: (Let's select the files here.)
            //And upload them.
            //So now we have images that are available on the 'azure blob storage'
            //When you try to access 
        }
    }
}
