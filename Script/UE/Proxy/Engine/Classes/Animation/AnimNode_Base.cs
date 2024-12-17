using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNode_Base")]
	public partial class FAnimNode_Base : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimNode_Base");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_Base() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimNode_Base() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimNode_Base A, FAnimNode_Base B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_Base A, FAnimNode_Base B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_Base;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FAnimNodeFunctionRef InitialUpdateFunction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InitialUpdateFunction, __ReturnBuffer);

					return *(FAnimNodeFunctionRef*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InitialUpdateFunction, __InBuffer);
				}
			}
		}

		public FAnimNodeFunctionRef BecomeRelevantFunction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BecomeRelevantFunction, __ReturnBuffer);

					return *(FAnimNodeFunctionRef*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BecomeRelevantFunction, __InBuffer);
				}
			}
		}

		public FAnimNodeFunctionRef UpdateFunction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UpdateFunction, __ReturnBuffer);

					return *(FAnimNodeFunctionRef*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UpdateFunction, __InBuffer);
				}
			}
		}

		private static uint __InitialUpdateFunction = 0;

		private static uint __BecomeRelevantFunction = 0;

		private static uint __UpdateFunction = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}