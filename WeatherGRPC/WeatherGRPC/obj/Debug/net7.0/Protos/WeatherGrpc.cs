// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/weather.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace WeatherGRPC {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Weather
  {
    static readonly string __ServiceName = "weather.Weather";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::WeatherGRPC.EmptyMessage> __Marshaller_weather_EmptyMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::WeatherGRPC.EmptyMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::WeatherGRPC.WeatherValues> __Marshaller_weather_WeatherValues = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::WeatherGRPC.WeatherValues.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::WeatherGRPC.WeatherId> __Marshaller_weather_WeatherId = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::WeatherGRPC.WeatherId.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::WeatherGRPC.EmptyMessage, global::WeatherGRPC.WeatherValues> __Method_GetAllData = new grpc::Method<global::WeatherGRPC.EmptyMessage, global::WeatherGRPC.WeatherValues>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetAllData",
        __Marshaller_weather_EmptyMessage,
        __Marshaller_weather_WeatherValues);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::WeatherGRPC.WeatherId, global::WeatherGRPC.WeatherValues> __Method_GetWeatherById = new grpc::Method<global::WeatherGRPC.WeatherId, global::WeatherGRPC.WeatherValues>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetWeatherById",
        __Marshaller_weather_WeatherId,
        __Marshaller_weather_WeatherValues);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::WeatherGRPC.WeatherValues, global::WeatherGRPC.WeatherValues> __Method_AddWeather = new grpc::Method<global::WeatherGRPC.WeatherValues, global::WeatherGRPC.WeatherValues>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddWeather",
        __Marshaller_weather_WeatherValues,
        __Marshaller_weather_WeatherValues);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::WeatherGRPC.WeatherValues, global::WeatherGRPC.WeatherValues> __Method_UpdateWeather = new grpc::Method<global::WeatherGRPC.WeatherValues, global::WeatherGRPC.WeatherValues>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateWeather",
        __Marshaller_weather_WeatherValues,
        __Marshaller_weather_WeatherValues);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::WeatherGRPC.WeatherId, global::WeatherGRPC.EmptyMessage> __Method_DeleteWeather = new grpc::Method<global::WeatherGRPC.WeatherId, global::WeatherGRPC.EmptyMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteWeather",
        __Marshaller_weather_WeatherId,
        __Marshaller_weather_EmptyMessage);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::WeatherGRPC.WeatherReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Weather</summary>
    [grpc::BindServiceMethod(typeof(Weather), "BindService")]
    public abstract partial class WeatherBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task GetAllData(global::WeatherGRPC.EmptyMessage request, grpc::IServerStreamWriter<global::WeatherGRPC.WeatherValues> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::WeatherGRPC.WeatherValues> GetWeatherById(global::WeatherGRPC.WeatherId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::WeatherGRPC.WeatherValues> AddWeather(global::WeatherGRPC.WeatherValues request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::WeatherGRPC.WeatherValues> UpdateWeather(global::WeatherGRPC.WeatherValues request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::WeatherGRPC.EmptyMessage> DeleteWeather(global::WeatherGRPC.WeatherId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(WeatherBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAllData, serviceImpl.GetAllData)
          .AddMethod(__Method_GetWeatherById, serviceImpl.GetWeatherById)
          .AddMethod(__Method_AddWeather, serviceImpl.AddWeather)
          .AddMethod(__Method_UpdateWeather, serviceImpl.UpdateWeather)
          .AddMethod(__Method_DeleteWeather, serviceImpl.DeleteWeather).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, WeatherBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAllData, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::WeatherGRPC.EmptyMessage, global::WeatherGRPC.WeatherValues>(serviceImpl.GetAllData));
      serviceBinder.AddMethod(__Method_GetWeatherById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::WeatherGRPC.WeatherId, global::WeatherGRPC.WeatherValues>(serviceImpl.GetWeatherById));
      serviceBinder.AddMethod(__Method_AddWeather, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::WeatherGRPC.WeatherValues, global::WeatherGRPC.WeatherValues>(serviceImpl.AddWeather));
      serviceBinder.AddMethod(__Method_UpdateWeather, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::WeatherGRPC.WeatherValues, global::WeatherGRPC.WeatherValues>(serviceImpl.UpdateWeather));
      serviceBinder.AddMethod(__Method_DeleteWeather, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::WeatherGRPC.WeatherId, global::WeatherGRPC.EmptyMessage>(serviceImpl.DeleteWeather));
    }

  }
}
#endregion
