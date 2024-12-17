using Script.CoreUObject;
using Script.Chaos;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionSamplePhysicsVectorField")]
	public partial class UMaterialExpressionSamplePhysicsVectorField : UMaterialExpression, IStaticClass
	{
		public FExpressionInput WorldPosition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WorldPosition, __ReturnBuffer);

					return *(FExpressionInput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WorldPosition, __InBuffer);
				}
			}
		}

		public EFieldVectorType FieldTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FieldTarget, __ReturnBuffer);

					return *(EFieldVectorType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FieldTarget, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialExpressionSamplePhysicsVectorField");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __WorldPosition = 0;

		private static uint __FieldTarget = 0;
	}
}