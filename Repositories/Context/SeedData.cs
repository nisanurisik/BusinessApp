using BusinessApp.Entities;
using BusinessApp.Repositories.Context;
using Microsoft.EntityFrameworkCore;

namespace BusinessApp.Repositories
{
  public static class SeedData
  {
    public static void TestData(IApplicationBuilder app)
    {
      var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<AppDbContext>();
      if (context != null)
      {
        if (context.Database.GetPendingMigrations().Any())
        {
          context.Database.Migrate();
        }

        if (!context.Roles.Any())
        {
          context.Roles.AddRange(
              new Role { Name = "Admin" },
              new Role { Name = "Employer" },
              new Role { Name = "User" }
          );
          context.SaveChanges();
        }

        if (!context.JobTypes.Any())
        {
          context.JobTypes.AddRange(
              new JobType { Type = "Full Time" },
              new JobType { Type = "Part Time" }
          );
          context.SaveChanges();
        }

        if (!context.Categories.Any())
        {
          context.Categories.AddRange(
              new Category { Name = "Software Development" },
              new Category { Name = "Finance" },
              new Category { Name = "Accountant" },
              new Category { Name = "Sales Consultant" },
              new Category { Name = "Customer Representative" },
              new Category { Name = "Sales Representative" },
              new Category { Name = "Accounting Staff" },
              new Category { Name = "Store Manager" }
          );
          context.SaveChanges();
        }

        if (!context.Employers.Any())
        {
          context.Employers.AddRange(
              new Employer
              {
                CompanyName = "Google",
                JobId = 1,
                UserId = 1
              },
              new Employer
              {
                CompanyName = "Microsoft",
                JobId = 2,
                UserId = 2
              },
              new Employer
              {
                CompanyName = "JP Morgan",
                JobId = 3,
                UserId = 3
              },
              new Employer
              {
                CompanyName = "Amazon",
                JobId = 4,
                UserId = 4
              },
              new Employer
              {
                CompanyName = "Tesla",
                JobId = 5,
                UserId = 1
              },
              new Employer
              {
                CompanyName = "Netflix",
                JobId = 6,
                UserId = 2
              }
          );
          context.SaveChanges();
        }

        if (!context.Users.Any())
        {
          context.Users.AddRange(
              new User
              {
                FirstName = "Muhammet Onur",
                LastName = "Aydınoğlu",
                Email = "onur@example.com",
                Password = "onur",
                PhoneNumber = "+905551112233",
                DateOfBirth = new DateTime(1998, 09, 14),
                ProfileImage = "profile.webp",
                Education = "Computer Engineering",
                Skills = "C#, .NET, SQL",
                ResumeUrl = "cv.pdf",
                RoleId = 1,
                EmployerId = 1
              },
              new User
              {
                FirstName = "Nisa Nur",
                LastName = "Işık",
                Email = "nisa@example.com",
                Password = "nisa",
                PhoneNumber = "+905554445566",
                DateOfBirth = new DateTime(1999, 12, 20),
                ProfileImage = "profile.webp",
                Education = "Computer Engineering",
                Skills = "Marketing, HR, Excel",
                ResumeUrl = "cv.pdf",
                RoleId = 1,
                EmployerId = 1
              },
              new User
              {
                FirstName = "Elisa",
                LastName = "Aydınoğlu",
                Email = "elisa@example.com",
                Password = "elisa",
                PhoneNumber = "+905556667788",
                DateOfBirth = new DateTime(2029, 2, 15),
                ProfileImage = "profile.webp",
                Education = "Information Technology",
                Skills = "JavaScript, React, Node.js",
                ResumeUrl = "cv.pdf",
                RoleId = 3,
                EmployerId = 1
              },
              new User
              {
                FirstName = "Yağız",
                LastName = "Aydınoğlu",
                Email = "yagiz@example.com",
                Password = "elisa",
                PhoneNumber = "+905556667788",
                DateOfBirth = new DateTime(2030, 2, 15),
                ProfileImage = "profile.webp",
                Education = "Information Technology",
                Skills = "JavaScript, React, Node.js",
                ResumeUrl = "cv.pdf",
                RoleId = 2,
                EmployerId = 2
              }
          );
          context.SaveChanges();
        }

        if (!context.Jobs.Any())
        {
          context.Jobs.AddRange(
              new Job
              {
                Title = "Senior Software Engineer",
                Description = "Develop and maintain enterprise applications.",
                Location = "İstanbul",
                SalaryRange = "10000-15000",
                IsActive = true,
                RemoteOption = true,
                JobImage = "~/img/Job/8.webp",
                JobTypeId = 1,
                EmployerId = 1,
                CategoryId = 1
              },
              new Job
              {
                Title = "Junior Web Developer",
                Description = "Assist in the creation of web-based applications.",
                Location = "Hatay",
                SalaryRange = "6000-8000",
                IsActive = true,
                RemoteOption = false,
                JobImage = "~/img/Job/8.webp",
                JobTypeId = 2,
                EmployerId = 3,
                CategoryId = 1
              },
              new Job
              {
                Title = "HR Specialist",
                Description = "Manage recruitment and employee relations.",
                Location = "Samsun",
                SalaryRange = "8000-10000",
                IsActive = true,
                RemoteOption = false,
                JobImage = "~/img/Job/8.webp",
                JobTypeId = 1,
                EmployerId = 2,
                CategoryId = 3
              },
              new Job
              {
                Title = "Financial Analyst",
                Description = "Analyze financial data and create reports.",
                Location = "İstanbul",
                SalaryRange = "9000-12000",
                IsActive = true,
                RemoteOption = true,
                JobImage = "~/img/Job/8.webp",
                JobTypeId = 1,
                EmployerId = 1,
                CategoryId = 2
              },
              new Job
              {
                Title = "Mobile App Developer",
                Description = "Develop mobile applications for Android and iOS.",
                Location = "Antalya",
                SalaryRange = "10000-14000",
                IsActive = true,
                RemoteOption = true,
                JobImage = "~/img/Job/8.webp",
                JobTypeId = 1,
                EmployerId = 3,
                CategoryId = 1
              },
              new Job
              {
                Title = "Marketing Specialist",
                Description = "Plan and execute marketing campaigns.",
                Location = "Bursa",
                SalaryRange = "7000-9000",
                IsActive = true,
                RemoteOption = false,
                JobImage = "~/img/Job/8.webp",
                JobTypeId = 2,
                EmployerId = 2,
                CategoryId = 3
              },
              new Job
              {
                Title = "DevOps Engineer",
                Description = "Maintain CI/CD pipelines and infrastructure.",
                Location = "İstanbul",
                SalaryRange = "11000-16000",
                IsActive = true,
                RemoteOption = true,
                JobImage = "~/img/Job/8.webp",
                JobTypeId = 1,
                EmployerId = 1,
                CategoryId = 1
              },
              new Job
              {
                Title = "Data Scientist",
                Description = "Analyze and model large datasets to extract insights.",
                Location = "Ankara",
                SalaryRange = "12000-18000",
                IsActive = true,
                RemoteOption = true,
                JobImage = "~/img/Job/8.webp",
                JobTypeId = 1,
                EmployerId = 3,
                CategoryId = 1
              }
          );
          context.SaveChanges();
        }

        if (!context.Blogs.Any())
        {
          context.Blogs.AddRange(
              new Blog
              {
                Title = "What Does a Web Developer Do?",
                Description = "Web developers design, create, and maintain websites and web apps.Learn HTML, CSS, JavaScript, and practice regularly to excel in this field.",
                IsActive = true,
                BlogImage = "~/img/Job/8.webp",
                UserId = 1,
                CategoryId = 1
              },
              new Blog
              {
                Title = "What Does a Database Admin Do?",
                Description = "Database admins manage, organize, and secure databases. Proficiency in SQL and a background in IT or computer science are essential.",
                IsActive = true,
                BlogImage = "~/img/Job/8.webp",
                UserId = 1,
                CategoryId = 1
              },
              new Blog
              {
                Title = "What Does a Digital Marketer Do?",
                Description = "Digital marketers use SEO, ads, and social media to promote products. Training in digital tools and strong analytical skills are key.",
                IsActive = true,
                BlogImage = "~/img/Job/8.webp",
                UserId = 1,
                CategoryId = 1
              },
              new Blog
              {
                Title = "Introduction to Full-Stack Development",
                Description = "A beginner's guide to understanding full-stack web development.",
                IsActive = true,
                BlogImage = "~/img/Job/8.webp",
                UserId = 1,
                CategoryId = 1
              },
              new Blog
              {
                Title = "Top Financial Strategies for Startups",
                Description = "Effective financial strategies to help startups manage resources efficiently.",
                IsActive = true,
                BlogImage = "~/img/Job/8.webp",
                UserId = 2,
                CategoryId = 2
              },
              new Blog
              {
                Title = "Human Resources Trends in 2025",
                Description = "Exploring the latest trends in HR and recruitment for the coming years.",
                IsActive = true,
                BlogImage = "~/img/Job/8.webp",
                UserId = 4,
                CategoryId = 3
              },
              new Blog
              {
                Title = "React vs Angular: Which One to Choose?",
                Description = "A detailed comparison between React and Angular frameworks.",
                IsActive = true,
                BlogImage = "~/img/Job/8.webp",
                UserId = 3,
                CategoryId = 1
              },
              new Blog
              {
                Title = "The Role of Data Science in Modern Business",
                Description = "How data science is revolutionizing industries and decision-making.",
                IsActive = true,
                BlogImage = "~/img/Job/8.webp",
                UserId = 3,
                CategoryId = 1
              }
          );
          context.SaveChanges();
        }

        if (!context.Cities.Any())
        {
          context.Cities.AddRange(
              new City { Name = "İstanbul" },
              new City { Name = "Ankara" },
              new City { Name = "İzmir" },
              new City { Name = "Bursa" },
              new City { Name = "Antalya" },
              new City { Name = "Adana" },
              new City { Name = "Konya" },
              new City { Name = "Hatay" },
              new City { Name = "Kayseri" },
              new City { Name = "Kocaeli" }
          );
          context.SaveChanges();
        }

      }
    }
  }
}