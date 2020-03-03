using System;
using Newtonsoft.Json;

namespace Shared.Dto
{
    public class GroupDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public GroupDto()
        {
            Title = JsonConvert.SerializeObject(Description);
        }
    }
}
