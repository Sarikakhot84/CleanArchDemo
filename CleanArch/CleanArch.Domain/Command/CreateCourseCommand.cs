using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Commands
{
    public class CreateCourseCommand:CourseCommand
    {

        public CreateCourseCommand(string name,string desc,string imgUrl)
        {
            Name = name;
            Description = desc;
            ImageUrl = imgUrl;
        }
    }
}
