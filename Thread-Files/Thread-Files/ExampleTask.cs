using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_Files
{
    internal class ExampleTask
    {
        public async Task GetById()
        {
            var datas = await _context.Categories.where(mbox => mbox.id = id);
            datas.name = "dwadawdwwa";
        }
        public async Task GetByName()
        {
            var datas = await _context.Categories.where(mbox => mbox.id = id);
            datas.name = "dwadawdwwa";
        }
    }
}
