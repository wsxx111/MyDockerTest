FROM microsoft/wcf

WORKDIR MyWcf

RUN powershell -NoProfile -Command \
    Import-module IISAdministration; \
    New-IISSite -Name "MyWcf"  -PhysicalPath C:\MyWcf\ -BindingInformation "*:83:"

EXPOSE 83

COPY MyWcf/ .