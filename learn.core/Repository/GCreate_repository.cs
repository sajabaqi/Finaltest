﻿using learn.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace learn.core.Repository
{
    public interface GCreate_repository
    {
        public List<Group_Create> getallGroups();
        public bool updateGroups(Group_Create group_Create);
        public bool deleteGroups(int id);
        public bool insertGroups(Group_Create group_Create);
        public Group_Create getbyidGroups(int id);
    }
}
