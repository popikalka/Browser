using System.Linq;
using PersonalBrowser.Core.BusinessObjects;
using PersonalBrowser.Core.Interfaces;
using PersonalBrowser.Core.DataAccess;
using AutoMapper;
using NLog;
using System;
using System.Data.Entity;

namespace PersonalBrowser.Core.Services
{
    public class DataBaseService : IDataBaseService
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private PersonalContext _context;

        public DataBaseService()
        {
            _context = new PersonalContext();
        }

        public bool AddLink(LinkDto link)
        {
            try
            {
                _context.Links.Add(Mapper.Map<LinkDto, Link>(link));
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                _logger.Error(e.ToString);
                throw new Exception("Ошибка при добавлении ссылки");
            }
        }

        public bool DeleteLink(LinkDto linkDto)
        {
            try
            {
                Link link = _context.Links.Single(x => x.Id == linkDto.Id);
                _context.Links.Remove(link);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                _logger.Error(e.ToString);
                throw new Exception("Ошибка при удалении ссылки");
            }
        }

        public bool EditLink(LinkDto link)
        {
            try
            {
                Link result = _context.Links.Single(x => x.Id == link.Id);
                result.Title = link.Title;
                result.Address = link.Address.ToString();
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                _logger.Error(e.ToString);
                throw new Exception("Ошибка при изменении ссылки");
            }
        }

        public UserDto GetUser(string userName)
        {
            User user = _context.Users
                .Include(x => x.Links)
                .SingleOrDefault(x => x.Name == userName);

            return user == null ? null : Mapper.Map<User, UserDto>(user);
        }
    }
}
