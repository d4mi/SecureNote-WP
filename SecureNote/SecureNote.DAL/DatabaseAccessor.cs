using SecureNote.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.DAL
{
    public class DatabaseAccessor
    {
        SQLiteConnection database;

        public DatabaseAccessor()
        {
            database = new SQLiteConnection("data.db");
            database.CreateTable<Note>();

            var s = database.Insert(new Note()
            {
                Title = "Hello",
                Text = "Tit"
            });

            var s2 = database.Insert(new Note()
            {
                Title = "Hello2",
                Text = "Tit2"
            });

            var r = database.Query<Note>("select * from Note");

            int i = 3;
        }

    }
}
