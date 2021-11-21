using MTFramework.Core.Entities.Concrete;
using MTFramework.Core.Utilities.Results;
using MTFramework.Core.Utilities.Security.Jwt;
using MTFramework.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTFramework.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExist(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
