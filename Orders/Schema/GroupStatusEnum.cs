using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;

namespace Groups.Schema
{
    class GroupStatusEnum : EnumerationGraphType
    {
        public GroupStatusEnum()
        {
            Name = "GroupStatuses";
            AddValue("CREATED", "Group was created", 2);
            AddValue("PROCESSING", "Group is being processed", 4);
            AddValue("COMPLETED", "Group is complete", 8);
            AddValue("CANCELLED", "Group is cancelled", 16);
            AddValue("CLOSED", "Group is closed", 32);

        }
    }
}
