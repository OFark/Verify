﻿class ArrayConverter : WriteOnlyJsonConverter
{
    public override bool CanConvert(Type objectType) =>
        true;

    public override void Write(VerifyJsonWriter writer, object value)
    {
        if (!writer.serialization.ShouldSerialize(value))
        {
            return;
        }

        Type? type = null;

        //HACK: to force typeNameHandling to be respected
        var handling = writer.Serializer.TypeNameHandling;
        if (handling is
            TypeNameHandling.All or
            TypeNameHandling.Objects or
            TypeNameHandling.Auto)
        {
            type = typeof(ArrayConverter);
        }

        writer.Serializer.Serialize(writer, value, type);
    }
}