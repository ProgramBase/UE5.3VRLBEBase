using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimGraphNode_Base")]
	public partial class UAnimGraphNode_Base : UK2Node, IStaticClass
	{
		public TArray<FOptionalPinFromProperty> ShowPinForProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShowPinForProperties, __ReturnBuffer);

					return *(TArray<FOptionalPinFromProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShowPinForProperties, __InBuffer);
				}
			}
		}

		public TMap<FName, FAnimGraphNodePropertyBinding> PropertyBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PropertyBindings, __ReturnBuffer);

					return *(TMap<FName, FAnimGraphNodePropertyBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PropertyBindings, __InBuffer);
				}
			}
		}

		public TSet<FName> AlwaysDynamicProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AlwaysDynamicProperties, __ReturnBuffer);

					return *(TSet<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AlwaysDynamicProperties, __InBuffer);
				}
			}
		}

		public EBlueprintUsage BlueprintUsage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlueprintUsage, __ReturnBuffer);

					return *(EBlueprintUsage*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlueprintUsage, __InBuffer);
				}
			}
		}

		public FMemberReference InitialUpdateFunction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialUpdateFunction, __ReturnBuffer);

					return *(FMemberReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialUpdateFunction, __InBuffer);
				}
			}
		}

		public FMemberReference BecomeRelevantFunction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BecomeRelevantFunction, __ReturnBuffer);

					return *(FMemberReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BecomeRelevantFunction, __InBuffer);
				}
			}
		}

		public FMemberReference UpdateFunction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UpdateFunction, __ReturnBuffer);

					return *(FMemberReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UpdateFunction, __InBuffer);
				}
			}
		}

		public FName Tag
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Tag, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Tag, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimGraphNode_Base");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ShowPinForProperties = 0;

		private static uint __PropertyBindings = 0;

		private static uint __AlwaysDynamicProperties = 0;

		private static uint __BlueprintUsage = 0;

		private static uint __InitialUpdateFunction = 0;

		private static uint __BecomeRelevantFunction = 0;

		private static uint __UpdateFunction = 0;

		private static uint __Tag = 0;
	}
}