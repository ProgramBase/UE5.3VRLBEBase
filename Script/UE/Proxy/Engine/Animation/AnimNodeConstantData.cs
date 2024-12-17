using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNodeConstantData")]
	public partial class FAnimNodeConstantData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimNodeConstantData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNodeConstantData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimNodeConstantData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimNodeConstantData A, FAnimNodeConstantData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNodeConstantData A, FAnimNodeConstantData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNodeConstantData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TScriptInterface<IAnimClassInterface> AnimClassInterface
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AnimClassInterface, __ReturnBuffer);

					return *(TScriptInterface<IAnimClassInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AnimClassInterface, __InBuffer);
				}
			}
		}

		public int NodeIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NodeIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NodeIndex, __InBuffer);
				}
			}
		}

		private static uint __AnimClassInterface = 0;

		private static uint __NodeIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}