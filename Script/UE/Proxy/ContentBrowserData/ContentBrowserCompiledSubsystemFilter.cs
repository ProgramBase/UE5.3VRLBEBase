﻿using Script.CoreUObject;
using Script.Library;

namespace Script.ContentBrowserData
{
	[PathName("/Script/ContentBrowserData.ContentBrowserCompiledSubsystemFilter")]
	public partial class FContentBrowserCompiledSubsystemFilter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ContentBrowserData.ContentBrowserCompiledSubsystemFilter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FContentBrowserCompiledSubsystemFilter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FContentBrowserCompiledSubsystemFilter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FContentBrowserCompiledSubsystemFilter A, FContentBrowserCompiledSubsystemFilter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FContentBrowserCompiledSubsystemFilter A, FContentBrowserCompiledSubsystemFilter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FContentBrowserCompiledSubsystemFilter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}