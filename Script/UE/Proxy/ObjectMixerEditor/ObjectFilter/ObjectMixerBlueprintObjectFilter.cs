using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ObjectMixerEditor
{
	[PathName("/Script/ObjectMixerEditor.ObjectMixerBlueprintObjectFilter")]
	public partial class UObjectMixerBlueprintObjectFilter : UObjectMixerObjectFilter, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ObjectMixerEditor.ObjectMixerBlueprintObjectFilter");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool ShouldIncludeUnsupportedProperties()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __ShouldIncludeUnsupportedProperties, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetShowTransientObjects()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetShowTransientObjects, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TSet<FName> GetPropertiesThatRequireListRefresh()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPropertiesThatRequireListRefresh, __ReturnBuffer);

				return *(TSet<FName>*)__ReturnBuffer;
			}
		}

		public virtual EObjectMixerInheritanceInclusionOptions GetObjectMixerPropertyInheritanceInclusionOptions()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetObjectMixerPropertyInheritanceInclusionOptions, __ReturnBuffer);

				return *(EObjectMixerInheritanceInclusionOptions*)__ReturnBuffer;
			}
		}

		public virtual EObjectMixerInheritanceInclusionOptions GetObjectMixerPlacementClassInclusionOptions()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetObjectMixerPlacementClassInclusionOptions, __ReturnBuffer);

				return *(EObjectMixerInheritanceInclusionOptions*)__ReturnBuffer;
			}
		}

		public virtual TSet<TSubclassOf<AActor>> GetObjectClassesToPlace()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetObjectClassesToPlace, __ReturnBuffer);

				return *(TSet<TSubclassOf<AActor>>*)__ReturnBuffer;
			}
		}

		public virtual TSet<UClass> GetObjectClassesToFilter()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetObjectClassesToFilter, __ReturnBuffer);

				return *(TSet<UClass>*)__ReturnBuffer;
			}
		}

		public virtual TSet<FName> GetForceAddedColumns()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetForceAddedColumns, __ReturnBuffer);

				return *(TSet<FName>*)__ReturnBuffer;
			}
		}

		public virtual TSet<FName> GetColumnsToShowByDefault()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetColumnsToShowByDefault, __ReturnBuffer);

				return *(TSet<FName>*)__ReturnBuffer;
			}
		}

		public virtual TSet<FName> GetColumnsToExclude()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetColumnsToExclude, __ReturnBuffer);

				return *(TSet<FName>*)__ReturnBuffer;
			}
		}

		private static uint __ShouldIncludeUnsupportedProperties = 0;

		private static uint __GetShowTransientObjects = 0;

		private static uint __GetPropertiesThatRequireListRefresh = 0;

		private static uint __GetObjectMixerPropertyInheritanceInclusionOptions = 0;

		private static uint __GetObjectMixerPlacementClassInclusionOptions = 0;

		private static uint __GetObjectClassesToPlace = 0;

		private static uint __GetObjectClassesToFilter = 0;

		private static uint __GetForceAddedColumns = 0;

		private static uint __GetColumnsToShowByDefault = 0;

		private static uint __GetColumnsToExclude = 0;
	}
}