﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;
using System.Linq;
using System.Threading.Tasks;
using OtripleS.Web.Api.Models.SemesterCourses;

namespace OtripleS.Web.Api.Services.SemesterCourses
{
	public interface ISemesterCourseService
	{
		ValueTask<SemesterCourse> CreateSemesterCourseAsync(SemesterCourse semesterCourse);
		ValueTask<SemesterCourse> RetrieveSemesterCourseByIdAsync(Guid semesterCourseId);
		IQueryable<SemesterCourse> RetrieveAllSemesterCourses();
	}
}