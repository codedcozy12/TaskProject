﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface ITaskRepository
    {
        Task<TaskItem?> GetByIdAsync(Guid taskId);
        Task AddAsync(TaskItem task);
        void Update(TaskItem task);
        void Delete(TaskItem task);
        Task<(List<TaskItem>, int)> GetCompletedTasksAsync(Guid userId, int page, int size);
        Task<(List<TaskItem>, int)> GetAllByUserAsync(Guid userId, int page, int size);
    }
}
