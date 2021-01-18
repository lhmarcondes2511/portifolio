using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCurriculum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MyCurriculum.Data {
    public class MyCurriculumContext : DbContext {
        public MyCurriculumContext(DbContextOptions<MyCurriculumContext> options) : base(options) {}
        public DbSet<MyCurriculum.Models.Language> Language { get; set; }
        public DbSet<MyCurriculum.Models.Topic> Topic { get; set; }
        public DbSet<MyCurriculum.Models.Social> Social { get; set; }

        public string Conn { get; set; }

        public MyCurriculumContext(string conn) {
            this.Conn = conn;
        }

        private MySqlConnection GetConnection() {
            return new MySqlConnection(Conn);
        }

        public DbSet<MyCurriculum.Models.Account> Account { get; set; }

    }
}
