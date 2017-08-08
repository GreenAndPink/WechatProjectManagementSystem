using ProjectManagementSystem.Services.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectManagementSystem.Models;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Services.Service
{
    public class ProjectService : IProjectService
    {
        public Task<bool> AddProjectProcess(string projectId, ProjectProcess projectProcess)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CommentOnProject(string projectId, ProjectComment projectComment)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CommentOnProjectStep(string projectProcessStepId, ProcessStepComment projectComment)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateNewProject(ProjectBasicInfo projectBasicInfo)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProjectDetail>> GetProjectByRegion(string regionId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProjectDetail>> GetProjectByUserInCharge(string idOfuserInCharge)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePojectBasicInfo(ProjectBasicInfo projectBasicInfo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePojectStatus(string projectId, string newStatus)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProjectProcessStep(string projectProcessId, string processStepId, ProjectProcess projectProcess)
        {
            throw new NotImplementedException();
        }
    }
}