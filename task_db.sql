PGDMP     ,                    x            task_db    10.13    10.13     �
           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            �
           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            �
           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false            �
           1262    26362    task_db    DATABASE     �   CREATE DATABASE task_db WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_United States.1252' LC_CTYPE = 'English_United States.1252';
    DROP DATABASE task_db;
             postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
             postgres    false            �
           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                  postgres    false    3                        3079    12924    plpgsql 	   EXTENSION     ?   CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;
    DROP EXTENSION plpgsql;
                  false            �
           0    0    EXTENSION plpgsql    COMMENT     @   COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';
                       false    1            �            1259    26376    __EFMigrationsHistory    TABLE     �   CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);
 +   DROP TABLE public."__EFMigrationsHistory";
       public         postgres    false    3            �            1259    26381 	   todo_task    TABLE     �   CREATE TABLE public.todo_task (
    id text NOT NULL,
    date text,
    title text,
    description text,
    complete real NOT NULL,
    status text
);
    DROP TABLE public.todo_task;
       public         postgres    false    3            �
          0    26376    __EFMigrationsHistory 
   TABLE DATA               R   COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
    public       postgres    false    196           �
          0    26381 	   todo_task 
   TABLE DATA               S   COPY public.todo_task (id, date, title, description, complete, status) FROM stdin;
    public       postgres    false    197   Z       r
           2606    26380 .   __EFMigrationsHistory PK___EFMigrationsHistory 
   CONSTRAINT     {   ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");
 \   ALTER TABLE ONLY public."__EFMigrationsHistory" DROP CONSTRAINT "PK___EFMigrationsHistory";
       public         postgres    false    196            t
           2606    26388    todo_task PK_todo_task 
   CONSTRAINT     V   ALTER TABLE ONLY public.todo_task
    ADD CONSTRAINT "PK_todo_task" PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.todo_task DROP CONSTRAINT "PK_todo_task";
       public         postgres    false    197            �
   *   x�32020�44103435����,�L��4�3Գ������ �<�      �
   �  x��W�r7=S_��]h��&/�r�\^�r�KC�=Ѓ!�}�24II)ǩ�tI���~�S�*&jZqũh����J��R����i�	g�Q�P��<ϊ缘��������b}O�|���A�w�7?:�&���� r>%�z}:Я��L��ngn�{���q��m�?@�}]��k����4�'���j���K=s��M�-��0�����D�״�eI��yθ��F��!�1�ʇ+������&o�0H�4����p!}]���ץn@��������(�r[eFҒe�
�iZs4n-�k�j5�*΁������݇q���[�֑�c�f��Vv��������r�3���`�GzF3��OR��+Õj����l����1� �������H�\��6*rSS)��Ze �R)i�ϒ���ϝ؉qa�Z`���$��d��@��b|�n���ܹa�b���^ó�a��Jz:���4�@z���D�Ɉ�m��\wK��焾�k �L<Lf��@;%	��v�U�����Z�R'�'���i�l1σGr�S�	�^��u�B�%	䷏�a٫πʋя5k������cs�Q�-��6��2�l��<��z8�;�$I^����O�s6�? ?#�ֵH-�]gK	�|=v�y�B{�:=�E�$W��������mkޜXbOza9W�*iU�
�3A�X�����x�ˑ��a�%Q�J���-� �[����EWЮIH�����=$-������2f�m�-�Ƀ�B��o���:i�DK'^>E]<��^�X����N�x?�����յ#_BC�jZWo*�,ZeM& 7��|$�9G��Y�%H>{&��ӛ׻���	Ji�/����Iؙ7��k�4�P�MO�+�%�(��,	�\:�]l&#Ȓi^XT@�]��,ϩ�0#JQ��d�΁<����Iup��Lc�-(��as������Ϲ�qб�\>:�.S ��7���`�R)V-*�*�-�ռV��9��V����c��e����g(�\ќcA��>(�Ri*јF�0Rʿkx�ߟu����.��2��2^r\�J)�,rI�n�6cB��V&�g��hz����*k�Ֆ�4�T9CQ�8 +������~n��N�������k;&R��h�q����8ڀ,î����K
��b	D��evo#���x��-��p�����q8pt��=m��7��t� ��]�9�����l�     