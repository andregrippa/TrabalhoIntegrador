CREATE TABLE [dbo].[Colaborador] (
    [Id]    INT             IDENTITY (1, 1) NOT NULL,
    [Nome]  NVARCHAR (30)   NOT NULL,
    [Funcao] NVARCHAR (30) NOT NULL,
    CONSTRAINT [Pk_IdColaborador] PRIMARY KEY CLUSTERED ([Id] ASC)
);