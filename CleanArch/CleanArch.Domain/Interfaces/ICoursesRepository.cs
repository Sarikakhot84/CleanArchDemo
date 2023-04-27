﻿using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Interfaces
{
    public interface ICoursesRepository
    {
        IEnumerable<Course> GetCourses();
        void Add(Course course);
    }
}
