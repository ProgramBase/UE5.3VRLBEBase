using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTools
{
	[PathName("/Script/MovieSceneTools.ControlToTransformMappings")]
	public partial class FControlToTransformMappings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTools.ControlToTransformMappings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlToTransformMappings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FControlToTransformMappings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FControlToTransformMappings A, FControlToTransformMappings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlToTransformMappings A, FControlToTransformMappings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlToTransformMappings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FControlRigChannelEnum ControlChannel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ControlChannel, __ReturnBuffer);

					return *(FControlRigChannelEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ControlChannel, __InBuffer);
				}
			}
		}

		public FTransformChannelEnum FBXChannel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FBXChannel, __ReturnBuffer);

					return *(FTransformChannelEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FBXChannel, __InBuffer);
				}
			}
		}

		public bool bNegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bNegate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bNegate, __InBuffer);
				}
			}
		}

		private static uint __ControlChannel = 0;

		private static uint __FBXChannel = 0;

		private static uint __bNegate = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}