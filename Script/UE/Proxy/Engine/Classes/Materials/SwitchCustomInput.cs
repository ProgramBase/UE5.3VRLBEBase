using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SwitchCustomInput")]
	public partial class FSwitchCustomInput : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SwitchCustomInput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSwitchCustomInput() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSwitchCustomInput() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSwitchCustomInput A, FSwitchCustomInput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSwitchCustomInput A, FSwitchCustomInput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSwitchCustomInput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName InputName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputName, __InBuffer);
				}
			}
		}

		public FExpressionInput Input
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Input, __ReturnBuffer);

					return *(FExpressionInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Input, __InBuffer);
				}
			}
		}

		private static uint __InputName = 0;

		private static uint __Input = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}