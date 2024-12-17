using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BlueprintTypeConversions")]
	public partial class UBlueprintTypeConversions : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.BlueprintTypeConversions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static TSet<int> ConvertSetType(TSet<int> InSet)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSet?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertSetType, __InBuffer, __ReturnBuffer);

				return *(TSet<int>*)__ReturnBuffer;
			}
		}

		public static TMap<int, int> ConvertMapType(TMap<int, int> InMap)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMap?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertMapType, __InBuffer, __ReturnBuffer);

				return *(TMap<int, int>*)__ReturnBuffer;
			}
		}

		public static int ConvertFVector4fToFVector4d(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFVector4fToFVector4d, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int ConvertFVector4dToFVector4f(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFVector4dToFVector4f, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int ConvertFVector3fToFVector3d(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFVector3fToFVector3d, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int ConvertFVector3dToFVector3f(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFVector3dToFVector3f, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int ConvertFVector2fToFVector2d(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFVector2fToFVector2d, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int ConvertFVector2dToFVector2f(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFVector2dToFVector2f, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int ConvertFTransform3fToFTransform3d(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFTransform3fToFTransform3d, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int ConvertFTransform3dToFTransform3f(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFTransform3dToFTransform3f, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int ConvertFRotator3fToFRotator3d(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFRotator3fToFRotator3d, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int ConvertFRotator3dToFRotator3f(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFRotator3dToFRotator3f, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int ConvertFQuat4fToFQuat4d(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFQuat4fToFQuat4d, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int ConvertFQuat4dToFQuat4f(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFQuat4dToFQuat4f, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int ConvertFPlane4fToFPlane4d(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFPlane4fToFPlane4d, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int ConvertFPlane4dToFPlane4f(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFPlane4dToFPlane4f, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int ConvertFMatrix44fToFMatrix44d(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFMatrix44fToFMatrix44d, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int ConvertFMatrix44dToFMatrix44f(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFMatrix44dToFMatrix44f, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int ConvertFBox2fToFBox2d(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFBox2fToFBox2d, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int ConvertFBox2dToFBox2f(int InFromData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InFromData;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertFBox2dToFBox2f, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static TArray<int> ConvertArrayType(TArray<int> InArray)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InArray?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertArrayType, __InBuffer, __ReturnBuffer);

				return *(TArray<int>*)__ReturnBuffer;
			}
		}

		private static uint __ConvertSetType = 0;

		private static uint __ConvertMapType = 0;

		private static uint __ConvertFVector4fToFVector4d = 0;

		private static uint __ConvertFVector4dToFVector4f = 0;

		private static uint __ConvertFVector3fToFVector3d = 0;

		private static uint __ConvertFVector3dToFVector3f = 0;

		private static uint __ConvertFVector2fToFVector2d = 0;

		private static uint __ConvertFVector2dToFVector2f = 0;

		private static uint __ConvertFTransform3fToFTransform3d = 0;

		private static uint __ConvertFTransform3dToFTransform3f = 0;

		private static uint __ConvertFRotator3fToFRotator3d = 0;

		private static uint __ConvertFRotator3dToFRotator3f = 0;

		private static uint __ConvertFQuat4fToFQuat4d = 0;

		private static uint __ConvertFQuat4dToFQuat4f = 0;

		private static uint __ConvertFPlane4fToFPlane4d = 0;

		private static uint __ConvertFPlane4dToFPlane4f = 0;

		private static uint __ConvertFMatrix44fToFMatrix44d = 0;

		private static uint __ConvertFMatrix44dToFMatrix44f = 0;

		private static uint __ConvertFBox2fToFBox2d = 0;

		private static uint __ConvertFBox2dToFBox2f = 0;

		private static uint __ConvertArrayType = 0;
	}
}