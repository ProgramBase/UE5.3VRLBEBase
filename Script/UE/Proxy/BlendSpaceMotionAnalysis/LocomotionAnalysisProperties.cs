using Script.CoreUObject;
using Script.Engine;
using Script.Persona;
using Script.Library;

namespace Script.BlendSpaceMotionAnalysis
{
	[PathName("/Script/BlendSpaceMotionAnalysis.LocomotionAnalysisProperties")]
	public partial class ULocomotionAnalysisProperties : UAnalysisProperties, IStaticClass
	{
		public EAnalysisLocomotionAxis FunctionAxis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FunctionAxis, __ReturnBuffer);

					return *(EAnalysisLocomotionAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FunctionAxis, __InBuffer);
				}
			}
		}

		public FBoneSocketTarget PrimaryBoneSocket
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryBoneSocket, __ReturnBuffer);

					return *(FBoneSocketTarget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PrimaryBoneSocket, __InBuffer);
				}
			}
		}

		public FBoneSocketTarget SecondaryBoneSocket
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SecondaryBoneSocket, __ReturnBuffer);

					return *(FBoneSocketTarget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SecondaryBoneSocket, __InBuffer);
				}
			}
		}

		public EAnalysisLinearAxis CharacterFacingAxis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CharacterFacingAxis, __ReturnBuffer);

					return *(EAnalysisLinearAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CharacterFacingAxis, __InBuffer);
				}
			}
		}

		public EAnalysisLinearAxis CharacterUpAxis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CharacterUpAxis, __ReturnBuffer);

					return *(EAnalysisLinearAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CharacterUpAxis, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlendSpaceMotionAnalysis.LocomotionAnalysisProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __FunctionAxis = 0;

		private static uint __PrimaryBoneSocket = 0;

		private static uint __SecondaryBoneSocket = 0;

		private static uint __CharacterFacingAxis = 0;

		private static uint __CharacterUpAxis = 0;
	}
}