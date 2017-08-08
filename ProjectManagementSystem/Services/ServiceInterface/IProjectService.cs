using ProjectManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Services.ServiceInterface
{
    public interface IProjectService
    {
        Task<bool> CreateNewProject(ProjectBasicInfo projectBasicInfo);
        Task<List<ProjectDetail>> GetProjectByRegion(string regionId);
        Task<List<ProjectDetail>> GetProjectByUserInCharge(string idOfuserInCharge);
        Task<bool> UpdatePojectBasicInfo(ProjectBasicInfo projectBasicInfo);
        Task<bool> UpdatePojectStatus(string projectId, string newStatus);
        Task<bool> AddProjectProcess(string projectId, ProjectProcess projectProcess);
        Task<bool> UpdateProjectProcessStep(string projectProcessId,string processStepId, ProjectProcess projectProcess);
        Task<bool> CommentOnProject(string projectId, ProjectComment projectComment);
        Task<bool> CommentOnProjectStep(string projectProcessStepId, ProcessStepComment projectComment);
    }
}
