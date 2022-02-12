using Domain.Models;
using Domain.Models.User;
using Extensions.Helper;
using Extensions.ServiceConfigures.AppSettings;
using IdentityDbContext;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Validation;
using Microsoft.EntityFrameworkCore;
using Repository.Base;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer
{
    public class ResourceOwnerPasswordValidator:IResourceOwnerPasswordValidator
    {
        private readonly IRepository<int, UserEntity> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public ResourceOwnerPasswordValidator(IRepository<int, UserEntity> repository,IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            
            _unitOfWork.BeginTran();
            //ServiceRegisterEntity serviceRegisterEntity = new ServiceRegisterEntity() {
            //    ClientId = "client1",
            //    Secret = "secret",
            //    ServiceName="Api2",
            //    CreateTime=DateTime.Now,
            //    UpdateTime=DateTime.Now,
            //    IsDelete=false,
            //    Creator="caixianqi"
            //};
            //_repository.Insert(serviceRegisterEntity);
            //_repository.Insert(serviceRegisterEntity1);
            UserEntity userEntity = new UserEntity()
            {
                Password="123"
            };
            _unitOfWork.CommitTran();
            //根据context.UserName和context.Password与数据库的数据做校验，判断是否合法
            if (context.UserName == "wjk" && context.Password == "123")
            {
                 context.Result = new GrantValidationResult(
                 subject: context.UserName,
                 authenticationMethod: "custom",
                 claims: GetUserClaims());
            }
            else
            {

                //验证失败
                context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, "invalid custom credential");
            }
        }
        //可以根据需要设置相应的Claim
        private Claim[] GetUserClaims()
        {
            return new Claim[]
            {
            new Claim("UserId", 1.ToString()),
            new Claim(JwtClaimTypes.Name,"wjk"),
            new Claim(JwtClaimTypes.GivenName, "jaycewu"),
            new Claim(JwtClaimTypes.FamilyName, "yyy"),
            new Claim(JwtClaimTypes.Email, "977865769@qq.com"),
            new Claim(JwtClaimTypes.Role,"admin")
            };
        }
    }
}
