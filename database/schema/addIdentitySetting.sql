START
TRANSACTION;

CREATE TABLE `AppIdentitySettings`
(
    `Id` varchar
(255) CHARACTER
SET utf8mb4
NOT NULL,
    `Name` varchar
(200) CHARACTER
SET utf8mb4
NOT NULL,
    `Prefix` longtext CHARACTER
SET utf8mb4 NULL
,
    `CurrentNumber` int NOT NULL,
    `StepNumber` int NOT NULL,
    CONSTRAINT `PK_AppIdentitySettings` PRIMARY KEY
(`Id`)
) CHARACTER
SET=utf8mb4;

INSERT INTO `__EFMigrationsHistory` (`
MigrationId`,
`ProductVersion
`)
VALUES
('20230108154432_addIdentitySetting', '6.0.5');

COMMIT;

