﻿#region Copyright
///////////////////////////////////////////////////////////////////////////////
//
//  Copyright (c) Phoenix Contact GmbH & Co KG
//  This software is licensed under Apache-2.0
//
///////////////////////////////////////////////////////////////////////////////
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using PlcNext.Common.DataModel;
using PlcNext.Common.Tools;

namespace PlcNext.Common.Project
{
    public class ProjectEntity : EntityBaseDecorator
    {
        private ProjectEntity(IEntityBase entityBase) : base(entityBase)
        {
        }

        public static ProjectEntity Decorate(IEntityBase rootEntity)
        {
            if (!rootEntity.IsRoot())
            {
                throw new InvalidOperationException("This decorator can only decorate root entities.");
            }

            return Decorate<ProjectEntity>(rootEntity) ?? new ProjectEntity(rootEntity);
        }

        public MutableProjectSettings Settings => HasValue<MutableProjectSettings>()
                                                      ? Value<MutableProjectSettings>()
                                                      : HasContent(EntityKeys.ProjectSettingsKey)
                                                          ? this[EntityKeys.ProjectSettingsKey]
                                                             .Value<MutableProjectSettings>()
                                                          : new MutableProjectSettings();

        public Version Version => HasValue<Version>()
                                      ? Value<Version>()
                                      : HasContent(EntityKeys.ProjectVersionKey)
                                          ? this[EntityKeys.ProjectVersionKey].Value<Version>()
                                          : new Version(1, 0);

        public IEnumerable<Entity> Targets => HasContent(EntityKeys.TargetsKey)
                                                  ? this[EntityKeys.TargetsKey]
                                                  : Enumerable.Empty<Entity>();

        public IEnumerable<Entity> ValidatedTargets => HasContent(EntityKeys.ValidatedTargetsKey)
                                                  ? this[EntityKeys.ValidatedTargetsKey]
                                                  : Enumerable.Empty<Entity>();

        public Guid Id => this[EntityKeys.ProjectIdKey].Value<Guid>();
    }
}
