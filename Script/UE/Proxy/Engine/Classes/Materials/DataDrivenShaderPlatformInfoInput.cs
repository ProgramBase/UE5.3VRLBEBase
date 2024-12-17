using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DataDrivenShaderPlatformInfoInput")]
	public partial class FDataDrivenShaderPlatformInfoInput : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DataDrivenShaderPlatformInfoInput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDataDrivenShaderPlatformInfoInput() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDataDrivenShaderPlatformInfoInput() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDataDrivenShaderPlatformInfoInput A, FDataDrivenShaderPlatformInfoInput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDataDrivenShaderPlatformInfoInput A, FDataDrivenShaderPlatformInfoInput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDataDrivenShaderPlatformInfoInput;

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

		public EDataDrivenShaderPlatformInfoCondition PropertyCondition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyCondition, __ReturnBuffer);

					return *(EDataDrivenShaderPlatformInfoCondition*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyCondition, __InBuffer);
				}
			}
		}

		private static uint __InputName = 0;

		private static uint __PropertyCondition = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}