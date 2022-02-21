using KahveliKodlama.Application.Contract;
using KahveliKodlama.Application.Dto;
using KahveliKodlama.Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace KahveliKodlama.Service.Implementation
{
    public class FileUpload : IFileUpload
    {
        private readonly string[] extension = new string[] { "image/jpg", "image/png", "image/jpeg" };
        private UserManager<AppUser> _userManager;
        private IMemberService _memberService;

        public static IWebHostEnvironment _environment;

        public FileUpload(IWebHostEnvironment environment, UserManager<AppUser> userManager, IMemberService memberService)
        {
            _environment = environment;
            _userManager = userManager;
            _memberService = memberService;
        }
        public static IFormFile files { get; set; }


        public async Task<bool> Complate(IFormFile file, string userName)
        {
            //var currentUserName =  user.FindFirst(ClaimTypes.NameIdentifier).Value;
            //AppUser efe = await _userManager.FindByNameAsync(currentUserName);


            string[] _Split = userName.Split("+++");
            userName = _Split[0];   
            string email=_Split[1];

            //var result = await _userManager.FindByNameAsync(user.Identity.Name);

            //var userid= await _memberService.GetUser(result.Email);

            foreach (var item in extension)
            {
                if (file.ContentType.ToString() == item)
                {

                    string path = "C:\\Users\\Legion\\Desktop\\Angular\\Frontend\\src\\assets\\";


                    PathControl(userName);

                    string name = userName + file.FileName.Substring(file.FileName.LastIndexOf('.'));


                    using (FileStream stream = File.Create(path + name))
                    {

                 
                        await _memberService.UpdateMember(new MemberDto { Email=email, Image = path + name  }) ;
                        await file.CopyToAsync(stream);
                        await stream.FlushAsync();
                        return true;
                    }
                }
            }

            return false;
        }



        private void PathControl(string user)
        {
            string path = "C:\\Users\\Legion\\Desktop\\Angular\\Frontend\\src\\assets\\";


            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

        }
    }
}
