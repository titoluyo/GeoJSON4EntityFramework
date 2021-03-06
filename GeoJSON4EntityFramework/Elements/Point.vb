﻿Public Class Point
    Inherits GeoJsonGeometry(Of Point)
    Implements IGeoJsonGeometry

    Public Property Point As New Coordinate(0, 0)

    Public Overrides ReadOnly Property Coordinates As Object
        Get
            Return Point.Coordinate
        End Get
    End Property

    Public Overrides Sub CreateFromDbGeometry(inp As DbGeometryWrapper)
        If inp.Geometry.SpatialTypeName <> MyBase.TypeName Then Throw New ArgumentException
        Point = New Coordinate(inp.Geometry.XCoordinate, inp.Geometry.YCoordinate)
    End Sub

End Class