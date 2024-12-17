using Script.CoreUObject;
using Script.Library;
using Script.Reflection.Property;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimBlueprintFunctionData")]
	public partial class FAnimBlueprintFunctionData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimBlueprintFunctionData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimBlueprintFunctionData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimBlueprintFunctionData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimBlueprintFunctionData A, FAnimBlueprintFunctionData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimBlueprintFunctionData A, FAnimBlueprintFunctionData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimBlueprintFunctionData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TFieldPath<FStructProperty> OutputPoseNodeProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OutputPoseNodeProperty, __ReturnBuffer);

					return *(TFieldPath<FStructProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OutputPoseNodeProperty, __InBuffer);
				}
			}
		}

		public TArray<TFieldPath<FStructProperty>> InputPoseNodeProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputPoseNodeProperties, __ReturnBuffer);

					return *(TArray<TFieldPath<FStructProperty>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputPoseNodeProperties, __InBuffer);
				}
			}
		}

		public TArray<TFieldPath<FProperty>> InputProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputProperties, __ReturnBuffer);

					return *(TArray<TFieldPath<FProperty>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputProperties, __InBuffer);
				}
			}
		}

		private static uint __OutputPoseNodeProperty = 0;

		private static uint __InputPoseNodeProperties = 0;

		private static uint __InputProperties = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}